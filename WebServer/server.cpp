#include "server.h"

//constructors
Server::Server() : socket_(DEFAULT_PORT, DEFAULT_HOST, SOCKET_TYPE), docRoot_("./www"), indexFile_("index.html")
{

}

Server::Server(std::string root, std::string indexFile, uint16_t port, std::string host) : socket_(port, host, SOCKET_TYPE), docRoot_(root), indexFile_(indexFile)
{

}

//basics of the server function from class on tuesday
void Server::start(){
    socket_.bind(); 
    socket_.listen(); 

    std::cout << "Server started at Document Root: " << docRoot_ << std::endl; 

    while(true){
        Socket c(socket_.accept()); 
        std::vector<unsigned char> buffer(4096); 
        Response res; 

        ssize_t bytesRead = c.recv(buffer); 
        if(bytesRead <= 0){
            res.setCode(400); 
        }

        Request req(buffer); 

        //set response version and current date
        res.setVersion(req.getVersion());
        auto now = std::time(nullptr);
        char datebuf[100];
        std::strftime(datebuf, sizeof(datebuf), "%a, %d %b %Y %H:%M:%S GMT", std::gmtime(&now));
        res.addHeader("Date", datebuf);

        std::string filePath = docRoot_ + req.getPath(); 
        if(req.getPath() == "/") {
            filePath += indexFile_; 
        }
        
        

        //use stat() to find all the file information for headers 
        struct stat fileStats; 
        if(req.getMethod() != "GET" && req.getMethod() != "HEAD")
        {
            res.setCode(405); 
        } else if(stat(filePath.c_str(), &fileStats) < 0){
            res.setCode(404); 
        }else if (!(fileStats.st_mode & S_IRUSR)) {
            res.setCode(403); 
        } else {
            //check to see if file was modified for conditional GET
            std::string date = req.getHeader("If-Modified-Since");
            bool notModified = false; 
            if(!date.empty())
            {
                struct tm reqTime{};
                if(strptime(date.c_str(), "%a, %d %b %Y %H:%M:%S GMT", &reqTime))
                {
                    time_t modTime = timegm(&reqTime);
                    if(fileStats.st_mtime <= modTime)
                    {
                        notModified = true; 
                    }
                }
            }

            if (notModified){ //conditional GET meaning the file wasn't modified 
                res.setCode(304);
            } else {
                res.setCode(200); 
                //content length of file in bytes
            }

            res.addHeader("Content-Length", std::to_string(fileStats.st_size));
            //host header, same as request 
            res.addHeader("Host", req.getHeader("Host"));

            //using non-persistanct web server 
            res.addHeader("Connection", "close");

            //find the content type using the mapped values
            std::string ext = filePath.substr(filePath.find_last_of("."));
            if (HTTP_CONTENT_TYPES.count(ext)) {
                res.addHeader("Content-Type", HTTP_CONTENT_TYPES.at(ext));
            }

            //update Last-Modified header 
            char timebuf[100];
            std::tm *gmt = std::gmtime(&fileStats.st_mtime);
            std::strftime(timebuf, sizeof(timebuf), "%a, %d %b %Y %H:%M:%S GMT", gmt);
            res.addHeader("Last-Modified", timebuf);
        }
        
        if(req.getMethod() == "GET" && res.getCode() == 200){
            std::ifstream f(filePath, std::ios::in | std::ios::binary);
            uint64_t fileSize = fileStats.st_size;
            std::vector <unsigned char> payload(fileSize); 
            f.read(reinterpret_cast<char*>(payload.data()), fileSize);  // read() expects a char* parameter so a cast is needed
            f.close();
            res.setMessage(payload); 
        }

        std::vector<unsigned char> resBuffer; 
        res.toMessage(resBuffer); 

        std::string debugStr(resBuffer.begin(), resBuffer.end());
        std::cout << "--- SENDING ---\n" << debugStr << "\n---------------" << std::endl;
        
        c.send(resBuffer); 
        // std::string message(resBuffer.begin(), resBuffer.end()); 
        // std::cout << message << std::endl;

        // Log to stdout
        std::cout << "127.0.0.1 - [" << res.getHeader("Date") << "] " << req.getMethod() << " " << req.getPath() << " " << res.getCode() << " " << fileStats.st_size << std::endl;
        c.close(); 
    }

    socket_.close();
}