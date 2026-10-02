#ifndef _SOCKET_H
#define _SOCKET_H

#include <arpa/inet.h> // inet_addr
#include <cerrno>
#include <cstdio>
#include <cstdlib>
#include <cstring>
#include <iostream>
#include <netdb.h>
#include <netinet/in.h>
#include <string>
#include <sys/socket.h>
#include <sys/types.h>
#include <unistd.h>
#include <vector>

const int BACKLOG = 5;
const int MAXHOSTNAME = 256;
const uint16_t DEFAULT_PORT = 11111;
const int SOCKET_TYPE = SOCK_STREAM; // TCP, as opposed to SOCK_DGRAM
const std::string DEFAULT_HOST = "127.0.0.1";

class Socket
{
  private:
    uint16_t port_;
    std::string host_;
    int socket_;
    int socket_type_;
    struct addrinfo* address_info;
    struct sockaddr_in servaddr;

  public:
    /**
     * @brief Socket constructor
     *
     * This function creates an object using a host and port comination
     * required to create a socket and connect to a host or open a server
     * socket.
     *
     * @param uint16_t The port number. 0-65'535, default = 43500
     * @param std::string the hostname, default = "127.0.0.1"
     * @param int socket_type, default: SOCK_STREAM (TCP)
     */
    Socket(uint16_t port = DEFAULT_PORT, std::string host = DEFAULT_HOST,
           int socket_type = SOCKET_TYPE);

    /**
     * @brief Socket constructor which creates an object from an existing socket
     *
     * This function creates an object from an existing socket.
     *
     * @param int The socket descriptor.
     */
    Socket(int socket);

    /**
     * @brief Socket destructor
     */
    ~Socket();

    /**
     * @brief Connect to a remote socket
     */
    void connect(void);

    /**
     * @brief bind a socket to a port
     */
    void bind(void);

    /**
     * @brief listen on a bound port
     */
    void listen(void);

    /**
     * @brief accepts a client connection on a listening socket
     *
     * This function accepts a client connection on a listening socket.
     *
     * @param optionally provide a sockaddr_in to hold the client IP address
     * @return The client socket descriptor.
     */
    int accept(void);
    // int accept(struct sockaddr_in* addr, socklen_t* addr_len);

    /**
     * @brief send data (TCP)
     *
     * This function sends a payload defined in a vector
     *
     * @param std::vector<unsigned char> message: the payload to transmit
     * @return The number of bytes transmitted
     */
    // ssize_t send(const unsigned char *message, int message_length);
    ssize_t send(const std::vector<unsigned char>& payload);

    /**
     * @brief receive data (TCP)
     *
     * This function receives a message and stores it in a vector
     *
     * @param std::vector<unsigned char> buf: the vector in which to store the
     * data
     * @return The number of bytes read from the socket
     */
    // ssize_t recv(unsigned char* buf);
    ssize_t recv(std::vector<unsigned char>& buffer);

    /**
     * @brief send data (UDP)
     *
     * This function sends a payload defined in a vector
     *
     * @param std::vector<unsigned char> message: the payload to transmit
     * @return The number of bytes transmitted
     */
    // ssize_t sendto(char* payload, int payload_length);
    // ssize_t sendto(const std::vector<unsigned char>& payload);

    /**
     * @brief receive data (UDP)
     *
     * This function receives a message and stores it in a vector
     *
     * @param std::vector<unsigned char> buf: the vector in which to store the
     * data
     * @return The number of bytes read from the socket
     */
    // ssize_t recvfrom(char* buffer, int buffer_size);
    // ssize_t recvfrom(std::vector<unsigned char>& buffer);

    /**
     * @brief close the socket
     */
    void close();
};

#endif
