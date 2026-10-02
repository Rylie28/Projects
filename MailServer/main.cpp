#include "socket.h"
#include <cstdlib>
#include <iostream>
#include <sys/types.h>
#include <vector>
#include <string>
#include "MailServer.h"


const bool DEBUG = true;
const uint32_t RECV_BUFFER_SIZE = 1024;

int main([[maybe_unused]] int argc, [[maybe_unused]] char* argv[]) 
{
   
    MailServer s(1025, "thomas.butler.edu"); 
    s.serverRun(); 

    
    return EXIT_SUCCESS;
}
