#include "socket.h"
#include <cstdlib>
#include <iostream>
#include <sys/types.h>
#include <vector>
#include <string>
#include "request.h"
#include "message.h"
#include "response.h"
#include "server.h"


const bool DEBUG = true;
const uint32_t RECV_BUFFER_SIZE = 1024;

int main([[maybe_unused]] int argc, [[maybe_unused]] char* argv[]) 
{
   
    Server s; 
    s.start(); 

    
    return EXIT_SUCCESS;
}
