# Socket Template

A guide for writing a Socket class for network programming assignments in CS435.

## Socket API

The Socket object will simplify our setup and interaction with sockets. The 
resulting API will work as follows (NOTE: parameters and return values aren't 
included):

```cpp
// for clients
Socket s;
s.connect();
s.send();
s.recv();
s.close();
```

Server programs will read:

```cpp
Socket s;
s.listen();
while(true)
	Socket c = Socket( s.accept() );
	c.recv();
	c.send();
	c.close();
s.close();
```

## Notes on unsigned char

In C, an *unsigned char* is frequently used to hold **bytes** of data.  The use of the 
unsigned modifier differentiates these variables from **char** types which are more clearly
text.

In c++17 **std::byte** was introduced which provides similar functionality in modern C++.

Using **unsigned char** will likely match most example code and work more naturally than std::byte,
but either *should* work.

## Notes on C-style APIs

C-Style APIs frequently use pointers for parameters, e.g.

```c
// ssize_t send(int sockfd, const void buf[.len], size_t len, int flags);
char* payload = "hello world";
int payload_length = 11;
int bytes_sent = ::send(socket_, (const unsigned char*)payload, payload_length, 0);
```

We can accomplish this with a std::vector, too, since the compiler guarantees that the data
will be stored contiguously and the data() method returns a pointer to the start of the data.

```c++
std::string message = "hello world";
std::vector<unsigned char> payload(message.begin(), message.end());
int bytes_sent = ::send(socket_, payload.data(), payload.size(), 0);
```

## Notes on C API Errors

Most UNIX and Linux OS APIs use **perror** to set an error code and to retrieve it one must:

1. test the return code of the function, e.g. send()
2. if it's less than zero, call perror()

e.g.

```c
if ( ::send(socket_, (const unsigned char*)payload, payload_length, 0) < 0 ) 
{ 
    perror("send"); 
}
```

In C++ we can achieve this using strerror, e.g.

```c++
if ( ::send(socket_, (const unsigned char*)payload, payload_length, 0) < 0 ) 
{ 
    std::cerr << "send: " << strerror(errno) << std::endl; 
}
```

## Testing

The tests use Google's C++ test library, libgtest.   There is a 
[primer](https://github.com/google/googletest/blob/main/docs/primer.md) to help
you get started if you wish to better understand the tests, modify them or write
additional tests.

To use the tests, you will use an included echo server (which responds with whatever
you send to it) running on your configured host and port.  Use `make test` to
compile the echo server and the test program.  In one terminal run `./echo` to start
the echo server and in a second terminal run `./test` to run the tests.

The tests will produce output reporting success or failure, e.g.

```
[==========] Running 4 tests from 1 test suite.
[----------] Global test environment set-up.
[----------] 4 tests from SocketTest
[ RUN      ] SocketTest.SendData
test_socket.cpp:41: Failure
Expected equality of these values:
  s.send(const_cast<unsigned char *>(data.data()), data.size())
    Which is: 0
  data.size()
    Which is: 8

[  FAILED  ] SocketTest.SendData (0 ms)
```
