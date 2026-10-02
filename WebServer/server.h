#ifndef _SERVER_H
#define _SERVER_H

#include "socket.h"
#include "message.h"
#include "request.h"
#include "response.h"
#include <iostream>
#include <string>
#include <vector>
#include <fstream>
#include <sstream>
#include <sys/stat.h>
#include <chrono>
#include <ctime>
#include <iomanip>

const std::unordered_map<std::string, std::string> HTTP_CONTENT_TYPES = {
    {".html", "text/html"},
    {".css", "text/css"},
    {".png","image/png"},
    {".jpg", "image/jpeg"}, 
    {".jpeg", "image/jpeg"}
};

class Server {
    private:
        Socket socket_; 
        std::string docRoot_; 
        std::string indexFile_; 

    public: 
        Server(); 
        Server(std::string root, std::string indexFile, uint16_t port, std::string host);
        ~Server(){ } 
        void start();  
}; 


#endif

