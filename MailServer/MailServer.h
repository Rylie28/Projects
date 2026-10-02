#ifndef _MAIL_SERVER_H
#define _MAIL_SERVER_H


#include <iostream>
#include <cstring>
#include <string>
#include <vector>

#include "socket.h"

/**
 * @class MailServer
 * @brief A class to manage the interaction with an SMTP mail server.
 * * This class uses a underlying Socket object to connect to a mail server
 * and facilitates a command-response loop compatible with SMTP standards.
 */
class MailServer {
    public: 
        /**
         * @brief Default constructor.
         * * Initializes the server using DEFAULT_PORT and DEFAULT_HOST defined in socket.h.
         */ 
        MailServer() : socket_(DEFAULT_PORT, DEFAULT_HOST, SOCKET_TYPE) {};

        /**
         * @brief Parameterized constructor.
         * * @param port The port number of the mail server (e.g., 25 or 1025).
         * @param host The hostname or IP address of the mail server.
         */ 
        MailServer(uint16_t port, std::string host) : socket_(port, host, SOCKET_TYPE) {}; 
        
        /**
         * @brief Destructor.
         * * Ensures the socket resources are cleaned up.
         */ 
        ~MailServer() {}; 

        /**
         * @brief Starts the main server interaction loop.
         * * This method performs the following:
         * 1. Establishes a connection to the host.
         * 2. Recieves first message from server
         * 3. If code recieved is 354, enters multi-line data entry mode.
         * 4. If code recieved is 221, terminates the connection.
         * 5. For all other codes, prompts user for a standard SMTP command.
         */
        void serverRun() {
            //connect to host and port of mail server 
            socket_.connect(); 
            std::string code = ""; 

            while(code != "221"){
                std::vector<unsigned char> buffer(4096); 

                //recieve server 
                ssize_t bytesRead = socket_.recv(buffer); 
                if(bytesRead <= 0 ) {
                    break; //connection closed or broke
                }

                //print the message sent by server for client
                std::string message(buffer.begin(), buffer.end()); 
                std::cout << message << std::endl; 

                //get the code to check if the server said goodbye
                code = message.substr(0, 3); 
                if(code == "221"){
                    break; 
                }

                if(code == "354"){
                    std::string body = ""; 
                    std::string line; 
                    while(std::getline(std::cin, line)){
                        if(line == ".") { //break out of loop if user typed a . 
                            break;
                        }else{
                            body += line + "\r\n"; //add to the body of the message every line
                        }
                    }

                    body += "\r\n.\r\n"; //add ending period

                    std::vector<unsigned char> payload(body.begin(), body.end()); 
                    socket_.send(payload); 
                }else{
                    //get user input as client to send to server
                    std::string input; 
                    std::getline(std::cin, input);
                    input += "\r\n";

                    //turn input into a vector to send to 
                    std::vector<unsigned char> payload(input.begin(), input.end()); 
                    socket_.send(payload); 
                }

                
            }
            socket_.close(); 

            
        }; 


    private: 
        Socket socket_; 
}; 


#endif
