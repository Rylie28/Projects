#include "socket.h"

Socket::Socket(uint16_t port, std::string host, int socket_type)
    : port_(port), host_(host), socket_type_(socket_type)
{
    
    if (socket_type_ == SOCK_DGRAM) {
        if ((socket_ = socket(AF_INET, SOCK_DGRAM, 0)) < 0) {
            perror("socket creation failed");
            exit(EXIT_FAILURE);
        }
    } else {
        if ((socket_ = socket(AF_INET, SOCK_STREAM, 0)) < 0) {
            perror("socket creation failed");
            exit(EXIT_FAILURE);
        }
        std::cout << "Socket created with port: " << port_ << std::endl;
    }

    memset(&servaddr, 0, sizeof(servaddr));
    servaddr.sin_family = AF_INET;
    servaddr.sin_addr.s_addr = inet_addr(host_.c_str());
    servaddr.sin_port = htons(port_);
}

Socket::Socket(int socket) : socket_(socket) {}

Socket::~Socket() { ::close(socket_); }

void Socket::connect()
{
    int rv;
    struct addrinfo hints {
    };
    hints.ai_family = AF_INET;
    hints.ai_socktype = socket_type_;

    if ((rv = getaddrinfo((char*)host_.c_str(), std::to_string(port_).c_str(),
                          &hints, &address_info)) != 0) {
        std::cerr << "getaddrinfo: " << gai_strerror(rv) << std::endl;
        throw std::runtime_error(gai_strerror(rv));
    }
    for (struct addrinfo* p = address_info; p != NULL; p = p->ai_next) {

        // connect
        if (::connect(socket_, p->ai_addr, p->ai_addrlen) == -1) {
            throw std::runtime_error(strerror(errno));
            ::close(socket_);
            continue;
        }

        break; // if we get here, we must have connected successfully
    }

    freeaddrinfo(address_info);
}

ssize_t Socket::send(const std::vector<unsigned char>& payload)
{
    ssize_t bytes = ::send(socket_, payload.data(), payload.size(), 0);
    if (bytes < 0) {
        throw std::runtime_error(strerror(errno));
    }
    return bytes;
}

ssize_t Socket::recv(std::vector<unsigned char>& buffer)
{
    ssize_t rc = 0; // Actual number of bytes read

    // rc is the number of characters returned.
    rc = ::recv(socket_, buffer.data(), buffer.size(), 0);
    if (rc >= 0 && static_cast<size_t>(rc) < buffer.size()) {
        buffer.resize(static_cast<size_t>(rc));
    }

    std::cout << "Number of bytes read: " << rc << std::endl;
    std::cout << "Received: "
              << std::string(buffer.begin(), buffer.begin() + rc) << std::endl;

    return rc;
}

void Socket::close(void) { ::close(socket_); }

void Socket::bind(void) {
    // Bind using the servaddr structure we filled in the constructor
    if (::bind(socket_, (struct sockaddr*)&servaddr, sizeof(servaddr)) < 0) {
        perror("Bind failed");
        exit(EXIT_FAILURE);
    }
}

void Socket::listen(void)
{
    ::listen(socket_, 1);
    std::cout << "Listening on " << host_ << ":" << port_ << std::endl;
}

int Socket::accept(void)
{
    int socketConnection = ::accept(socket_, NULL, NULL);
    if (socketConnection < 0) {
        perror("accept");
    }
    
    return socketConnection;
}

