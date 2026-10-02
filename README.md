# Projects for Networks Class

## Course Structure

A top-down introduction to computer networks from a layered point of view beginning with the applications layer and progressing toward the physical layer. Some specific topics we will cover include the TCP/IP models, socket programming, reliable data transfer, IP addressing and routing, WiFi and Ethernet.

**Course Objectives**
* Understand the TCP/IP network model layered approach and what service each layer provides
* Learn Socket programming socket api, connection and connectionless-oriented communication
* Understand Inter-process communication protocols and message formats
* Learn how to communicate between computers transporting packets using routing and broadcast protocols

## Projects 

### Design and Write a Socket Object
The socket API is used to write software which sends and receives data over the network.  The socket, once created, is an int variable which serves as a file descriptor, or identifier, to know how to send and receive data over the network with the help of your operating system. The socket API is a C-style api and is commonly used in an imperative style, e.g. a client program will:
* create a socket with socket()
* connect() to a remote process (the server)
* send() and recv() in a loop until the communication ends / program exits
* UDP programs will use sendto() and recvfrom()
* close() the socket

Instead of connect(), server programs will bind(), listen() and the accept() connections in a loop. Review the example client and server in the cs435 github and download them to try them out (run each program in a separate terminal!) Additionally, review the text for a brief overview: https://book.systemsapproach.org/foundation/software.html#socket-api 

**Requirements:**
- Must compile on thomas.butler.edu
- The Socket class should include
- three constructors:
- default
- host and port
- socket 
- methods - how to organize the required steps for clients and servers which include
- connect() - client connects to a server
- close() - closes a socket
- bind() - servers bind a socket to a port
- listen() - servers listen for connections on the bound port
- accept() - servers accept new client connections
- send() - send TCP data
- recv() - receive TCP data
- sendto() - send UDP data
- recvfrom() - receive UDP data
- Account for both SOCK_STREAM and SOCK_DGRAM sockets
- Account, for IPv4, or AF_INET only

### Create HTTP Request and Response Objects

Write c++ classes to represent an HTTP request and HTTP response.  We'll focus on requests first and what we don't work through in class will be completed and submitted for a regular assignment

### Create HTTP Message Object

Write an HTTP Message Object and use it to make an HTTP request.  This message object can optionally be tested by generating and sending a request to http://httpbin.org/get You will create a new class or classes for HTTP requests and responses. Your object should support GET, HEAD and POST methods (but only one at a time).  

**Marshaling Data**

The process of marshaling and unmarshaling, which you may know as serializing and unserializing or packing and unpacking, is the process of formatting data for transmission and unpacking data that's been received. Your class should have a method to marshal the request from the object.  This will assemble all of the parts into a single std::vector variable which can be used with send() and, when recv()'d, gives you a way to parse the data into separate class variables (either as a method, in a constructor or both).

**Requirements**
- the program must compile and run on thomas.butler.edu
- the program must use your socket object

### Write a Web Server 

Write a single-threaded web server! This assignment should use your existing work from both the Socket class and the HTTP message class(es).

**Additional steps and requirements for your web server:**
- creates a socket to listen on port 8080 (by default)
- configures a document root, or the directory where the web site files exist, for the website
- configures a default index file to open if the URL specifies a directory, index.html
- Handles GET and HEAD requests only
- Handles html, css, png, jpg and jpeg file types 
- You may wish to use another unordered_map to correlate file extensions to content-types.
- these correlate to text/html, text/css, image/png, image/jpeg and image/jpeg respectively 
- returns one of 200, 304, 400, 403, 404, 405, 500 statuses for each request
- 200 should be returned for successful requests
- 304 should be returned for conditional GETs
- 400 should be returned if the request is malformed
- 403 should be returned if the web server cannot read the file or directory
- 404 should be returned when the file does not exist
- 405 should be returned when the method is not GET
- 500 should be returned when something else unexpected happens
- may use non-persistent or persistent HTTP (your choice - only one is required)
- emits a log message to stdout describing each request handled including, in order:
- remote IP address
- date and time
- method
- path
- HTTP code
- bytes of response data
- compiles and runs on thomas.butler.edu

### Write a Mail User Agent

Write a mail user agent in C++ which uses your Socket class from the first assignment to send an email!

**Requirements:**
- the program must compile and run on thomas.butler.edu
- the program must create and use a Socket object
- the program must successfully send an email to the maildev server on thomas.butler.edu
- Your submission should be well organized and include remarks where needed

### Hunt the Wumpus Protocol 

Design an application layer protocol for a networked, multiplayer Hunt the Wumpus game! 

Hunt the Wumpus is a text-based computer game in which you attempt to hunt a creature called the Wumpus.  If you encounter the Wumpus, it will eat you and your game ends. Your adventure includes moving from cave to cave in a dungeon, avoiding bats and pits along the way, to, with luck, shoot an arrow into an adjacent cave and kill the wumpus to win the game.

You may alter the game for your design, e.g. capturing the wumpus instead of killing it so that it may be released for the game to continue.  Or maybe you envision a huge dungeon full of many wumpuses.  Whatever the case, be sure to document the change and why it is needed.

I've used the term cave to mean a single room and dungeon to mean the entire collection of caves that one explores in the game.  If you know these as rooms in a cave or something else, that works. Be consistent.

