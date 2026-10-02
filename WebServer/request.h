#ifndef _REQUEST_H
#define _REQUEST_H

#include <cstdint>
#include <string> 
#include <unordered_map> 
#include <vector> 
#include <sstream>
#include "message.h"

class Request : public Message
{
    
    public:
        Request() {};
        //Request(std::string url);
        Request(std::vector<unsigned char>& buffer)
        {
            std::string rawBuffer(buffer.begin(), buffer.end()); 
            std::istringstream iss(rawBuffer);  
            iss >> method_ >> path_ >> version_; 

            std::string line;
            std::getline(iss, line); 

            // 2. Loop through headers
            while (std::getline(iss, line) && line != "\r" && !line.empty()) {
                size_t colonPos = line.find(':');
                if (colonPos != std::string::npos) {
                    // Extract Key and Value
                    std::string key = line.substr(0, colonPos);
                    std::string value = line.substr(colonPos + 1);

                    // Trim whitespace from value (common in HTTP)
                    size_t first = value.find_first_not_of(" ");
                    size_t last = value.find_last_of("\r\n");
                    if (first != std::string::npos && last != std::string::npos) {
                        value = value.substr(first, last - first + 1);
                    }

                    // Add to the protected headers_ map in Message class
                    this->addHeader(key, value);
                }
            }
        }

        std::string getMethod() const { return method_; }
        void setMethod(std::string method) { method_ = method; }
        std::string getPath() const { return path_; }
        void setPath(std::string path) { path_ = path; }
        uint64_t getSize() { return toString().length(); }
        std::string toString()
        {
            std::string m = method_ + " " + path_ + " " + version_ + "\r\n";
            for (auto const& h: headers_)
            {
                                m += h.first + ": " + h.second + "\r\n";
            }
            m += "\r\n";
            return m;
        }

    private:
        std::string method_;
        std::string path_;
};

#endif