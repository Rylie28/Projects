#ifndef _RESPONSE_H
#define _RESPONSE_H

#include <cstdint>
#include <string> 
#include <unordered_map> 
#include <vector> 
#include "message.h"

class Response : public Message
{
    public: 
        Response() { }; 
        //~Response();
        int getCode() { return code_; }
        void setCode(int code) { code_ = code; }
        std::string getMessage() const { return message_; }
        void setMessage(std::vector<unsigned char> buffer) {
            std::string message(buffer.begin(), buffer.end()); 
            message_ = message; 
        }
        uint64_t getSize() { return toString().length(); }
        std::string toString()
        {
            std::string m = version_ + " " + std::to_string(code_) + " " + HTTP_STATUS_MESSAGES.at(code_) + "\r\n";
            for (auto const& h: headers_)
            {
                m += h.first + ": " + h.second + "\r\n";
            }
            m += "\r\n";  
            return m;
        }

    private: 
        int code_;   // could also be used as an int
        std::string message_;
};


#endif