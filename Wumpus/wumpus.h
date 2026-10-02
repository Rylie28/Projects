#ifndef _HUNT_WUMPUS_
#define _HUNT_WUMPUS_

//will have a couple classes with my game implementation and 
//will have the logic for multiplayer games etc..

//all the codes my protocol will use
const std::unordered_map<int, std::string> wumpusStatusCodes = {
    {200, "OK"},
    {201, "joined server"},
    {202, "joined game"},
    {405, "eaten by wumpus"},
    {406, "fell into pit"},
    {407, "picked up by bats"},
    {408, "Arrow hit wumpus"}, 
    {409, "Arrow missed"},
    {410, "another player eaten by wumpus"},
    {411, "player entered cave"},
    {413, "Player has yelled to everyone"},
    {414, "player is talking with you"},
    {600, "Unable to join server"}, 
    {601, "Unable to join game"},
    {602, "invalid cave number"}, 
    {603, "No arrows left"},
    {604, "invalid command"},
};

class HTWP 
{
    public: 
        HTWP(); 
        ~HTWP(); 

        //start protocol function, very similar to http start function
        //listen, binds, accepts 
        //then while not QUIT recieve requests
        //have a layered if statement that handles each command
        //each helper function will return the code for easier response message formatting
        //in the end sends a response socket_.send(payload); 
        void startProtocol(); 

        //functions for each of the player commands, these are simple helper functions that will run depending 
        //on the command of the request object
        int joinServer(); //connects player to the server 
        //socket_.connect(); 
        
        int playGame(); //finds an open game for a player to join, starts player in random cave
        //will probably just start a new wumpus game or look for open games

        int quitServer(); //closes socket connection to server, socket_.close()

        int exitGame(); // quits the wumpus game, stops running the game

        int move(int caveNum); //moves to cave number typed by player and returns code depending on what cave player moved to
        /* will send back 
        * code for invalid cave, code for wumpus, code for bats, code for pit, and code for OK
        */

        int fire(int caveNum); //fires an arrow into the cave number, returns code depending on outcome
        /* will send back
        * Code for invalid cave, hit or miss
        */

        int help(); //displays all the commands and lists what they each do

        int talk(std::string playerName); //allows you to send a request to server who then sends a response to given player with the message
        int yell(); //allows you sot send a request with your message to server who then sends a response to all players in current cave 

        //other helpful methods to make code shorter
        void printCaveMessage(); //prints out the current cave message, telling you your current cave, nearby caves and any hints
    private: 
        Socket socket_; //TCP socket_ will be on host: Thomas.butler.edu and port: 52805
        
}; 



//these are about the same as the HTTP where they are message objects that will 
//contain the responses and requests. Be able to marshell the data and have a 
//constructor that will take a vector and format it
class WumpusMessage {
public:

    // constructors
    WumpusMessage();
    //WumpusMessage(std::vector<unsigned char>& buffer);

    // header methods
    std::string getVersion(); 
    void setVersion(std::string version); 

    void addHeader(std::string key, std::string value);
    std::string getHeader(std::string key);
    void setBody(std::string body);
    std::string getBody();

    // creating the actual message
    static WumpusMessage toString() = 0; 

    // marshelling the message that will be sent/recieved
    std::string toMessage(std::vector<unsigned char>& buffer);

    private: 
        std::string version_; 
        std::unordered_map<std::string, std::string> headers_;
        std::string body_;
};

class request : public WumpusMessage
{
    public:
        request(); 
        request(std::vector<unsigned char>& buffer);

        std::string getCommand(); 
        void setCommand(std::string command); 
        std::string getArguments(); 
        void setArguments(std::string arguments); 

        void toString(); 

    private: 
        std::string command_; 
        std::string arguments_; //this will only be for numbers or player name
}; 

class response : public WumpusMessage
{
    public:
        response(); 
        response(std::vector<unsigned char>& buffer);

        std::string getCode(std::string code);

        void toString(); 

    private: 
        int code_; 
}; 


#endif
