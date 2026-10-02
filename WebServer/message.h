#ifndef _MESSAGE_H
#define _MESSAGE_H

#include <cstdint>
#include <string> 
#include <unordered_map> 
#include <vector> 

//1 use a single class for request and response
// --> easy to use but more parameters and confusion

//2 use two classes, one for request and one for response 
// --> more straightforward and less confusion 

//3 use three classes with inheritance, a base class for common methods and then request and response which inherit
// --> cleanest approach in terms of functionality and use (shared functionality)
// helps avoid errors but can be confusing for novice programmers 
const std::unordered_map<int, std::string> HTTP_STATUS_MESSAGES = {
    {200, "OK"},
    {301, "Moved Permanently"},
    {304, "Not Modified"},
    {307, "Temporary Redirect"},
    {308, "Permanent Redirect"},
    {400, "Bad Request"},
    {403, "Forbidden"},
    {404, "Not Found"},
    {405, "Method Not Allowed"},
    {500, "Internal Server Error"},
    {505, "HTTP Version Not Supported"},
};


class Message
{
    // shared base class
    public:
        Message() { version_ = "HTTP/1.1"; };
        ~Message() = default;
        std::string getVersion() const { return version_; }
        void setVersion(std::string version) { version_ = version; }
        void addHeader(std::string k, std::string v)
        {
            headers_[k] = v;
        }
        std::string getHeader(std::string k)
        {
            return headers_[k];
        }
        /**
         * @brief get the total size of the marshaled message
         *
         * @return uint64_t size in bytes
         */
        virtual uint64_t getSize() = 0;

        /**
         * @brief return the HTTP message header with no data
        *
         * @return std::string the HTTP message header
         */
        virtual std::string toString() = 0;

        /**
         * @brief Marshal the HTTP message including the header and
         * data into a vector payload to send using our Socket
         *
         * @param std::vector the vector to hold the payload
         */
        void toMessage(std::vector<unsigned char>& buffer)
        {
            // return to_string + data
            std::string m = toString();
            // copy the request into the buffer to send on the Socket
            std::copy(m.begin(), m.end(), std::back_inserter(buffer));
        }
    protected:
        std::string version_;
        std::unordered_map<std::string, std::string> headers_;
        std::vector<unsigned char> data_;
};
#endif