#include "server.h"

//constructors
Server::Server() : socket_(DEFAULT_PORT, DEFAULT_HOST, SOCKET_TYPE), docRoot_("./www"), indexFile_("index.html")
{

}

Server::Server(std::string root, std::string indexFile, uint16_t port, std::string host) : socket_(port, host, SOCKET_TYPE), docRoot_(root), indexFile_(indexFile)
{

}

void Server::start(){
    socket_.bind(); 
    socket_.listen(); 

    std::cout << "Server started at Document Root: " << docRoot_ << std::endl; 

    while(true){
        Socket c(socket_.accept()); 
        std::vector<unsigned char> buffer(4096); 
        Response res; 

        ssize_t bytesRead = c.recv(buffer); 
        if(bytesRead <= 0) 
        {
            res.setCode(400); 
        }

        Request req(buffer); 

        // Set response version and current date
        res.setVersion(req.getVersion());
        time_t t = time(0);
        char datebuf[100];
        std::strftime(datebuf, sizeof(datebuf), "%a, %d %b %Y %H:%M:%S GMT", localtime(&t));
        res.addHeader("Date", datebuf);

        // Build the filePath
        std::string filePath = docRoot_ + req.getPath();
        if(req.getPath() == "/") 
        {
            filePath += indexFile_;
        }
        
        
        struct stat fileStats;
        bool fileExists = (stat(filePath.c_str(), &fileStats) == 0);

        //if/else ladder checking all conditions
        if(req.getMethod() != "GET" && req.getMethod() != "HEAD") {//incorrect method
            res.setCode(405);
        } 
        else if(!fileExists) { //file doesn't exist
            res.setCode(404); 
        } 
        else if (!(fileStats.st_mode & S_IRUSR)) { //forbidden
            res.setCode(403);
        } else { // using a GET method but have to check modification date
            // Check If-Modified-Since for conditional GET
            std::string ims = req.getHeader("If-Modified-Since");
            bool notModified = false;
            if(!ims.empty()) { //makes sure there is a modification header
                struct tm reqTime{};
                if(strptime(ims.c_str(), "%a, %d %b %Y %H:%M:%S GMT", &reqTime)) {
                    time_t modTime = timegm(&reqTime);
                    if(fileStats.st_mtime <= modTime) {
                        notModified = true;
                    }
                }
            }

            if(notModified) {
                res.setCode(304);
            } else {
                // Successful file access: set 200 and add relevant headers
                res.setCode(200);
                res.addHeader("Connection", "close");
                res.addHeader("Content-Length", std::to_string(fileStats.st_size));

                // Add Last-Modified Header
                char lmBuf[100];
                std::strftime(lmBuf, sizeof(lmBuf), "%a, %d %b %Y %H:%M:%S GMT", std::gmtime(&fileStats.st_mtime));
                res.addHeader("Last-Modified", lmBuf);

                // Determine Content-Type
                size_t dotPos = filePath.find_last_of(".");
                if (dotPos != std::string::npos) {
                    std::string ext = filePath.substr(dotPos);
                    if (HTTP_CONTENT_TYPES.count(ext)) {
                        res.addHeader("Content-Type", HTTP_CONTENT_TYPES.at(ext));
                    }
                }

                // Load file content for GET requests
                if(req.getMethod() == "GET") {
                    std::ifstream f(filePath, std::ios::binary);
                    if(f) {
                        std::vector<unsigned char> payload((std::istreambuf_iterator<char>(f)), std::istreambuf_iterator<char>());
                        res.setMessage(payload);
                    }
                }
            }
        }

        // 4. Finalize message and send
        std::vector<unsigned char> resBuffer; 
        res.toMessage(resBuffer);
        c.send(resBuffer); 

        std::cout << "127.0.0.1 - [" << datebuf << "] \"" << req.getMethod() << " " << req.getPath() << "\" " 
                    << res.getCode() << " " << (res.getCode() == 200 ? fileStats.st_size : 0) << std::endl;
        
        c.close(); 
    }
}


#include "socket.h"
#include <cstdlib>
#include <iostream>
#include <sys/types.h>
#include <vector>
#include <string>
#include <cassert>
#include "request.h"
#include "message.h"
#include "response.h"
#include "server.h"


const bool DEBUG = true;
const uint32_t RECV_BUFFER_SIZE = 1024;

/*
 * A program which uses the Socket object to demonstrate
 * it's API which, for clients
 */

//test function that runs same tests as in python test script 
void runTest(const std::string& name, const std::string& req, int expectedCode) {
    std::cout << "[TEST] " << name << "... ";
    
    // 1. Setup connection
    Socket client(DEFAULT_PORT, DEFAULT_HOST, SOCKET_TYPE);
    try {
        client.connect();
    } catch (const std::exception& err) {
        std::cerr << "Connection failed: " << err.what() << std::endl;
        return;
    }

    // 2. Send the HTTP Request
    std::vector<unsigned char> payload(req.begin(), req.end());
    client.send(payload);

    // 3. Receive the Response
    std::vector<unsigned char> buffer(8192); // Large enough for headers
    ssize_t bytes = client.recv(buffer);
    
    if (bytes <= 0) {
        std::cout << "FAILED (No response)" << std::endl;
        return;
    }

    // 4. Parse response (Using a helper or simple logic)
    std::string raw(buffer.begin(), buffer.end());
    
    // Simple check for Status Code in the first line: "HTTP/1.1 200 OK"
    size_t firstSpace = raw.find(' ');
    size_t secondSpace = raw.find(' ', firstSpace + 1);
    int actualCode = std::stoi(raw.substr(firstSpace + 1, secondSpace - firstSpace - 1));

    if (actualCode == expectedCode) {
        std::cout << "PASSED" << std::endl;
    } else {
        std::cout << "FAILED (Expected " << expectedCode << ", got " << actualCode << ")" << std::endl;
    }
    
    client.close();
}

int main([[maybe_unused]] int argc, [[maybe_unused]] char* argv[]) 
{
    std::cout << "Starting C++ HTTP Client Tests..." << std::endl;

    // test_root
    runTest("test_root", "GET / HTTP/1.1\r\nHost: 127.0.0.1\r\n\r\n", 200);

    // test_html
    runTest("test_html", "GET /index.html HTTP/1.1\r\nHost: 127.0.0.1\r\n\r\n", 200);

    // test_jpg
    runTest("test_jpg", "GET /blue.jpg HTTP/1.1\r\nHost: 127.0.0.1\r\n\r\n", 200);

    // test_404
    runTest("test_404", "GET /nonexistent.file HTTP/1.1\r\nHost: 127.0.0.1\r\n\r\n", 404);

    return EXIT_SUCCESS;
}
