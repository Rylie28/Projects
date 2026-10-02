# Projects from CS248: Data Structures and Object - Oriented Programming 

## Course Structure

An algorithm is a sequence of steps which, when followed precisely, leads to the solution of a particular problem. Computer Science is the study of algorithms. This course is an introduction to computer science. We will study algorithms, their associate data structures, and their embodiment as programs using the Java programming language. We will also study a variety of computer science topics such as the storage and manipulation of data in computer hardware, operating systems and networks, software engineering, artificial intelligence, database systems, and more.

### Projects

#### Hunt the Wumpus

You are a mighty warrior, and armed with your trusty bow and 3 arrows, you enter The Caves in search of the mighty Wumpus. If you shoot the Wumpus, you are victorious and the masses will praise you, but if you stumble upon the Wumpus unawares, it will eat you! Also, beware of the webs of the giant poisonous spiders and the bottomless pits!
Your senses of smell and hearing will aid you on your quest, for the Wumpus does not bathe and can be smelled one room away. Also, the clicking mandibles of the poisonous spiders can be heard one room away, and the foul odor of a bottomless pit can be smelled one room away.

For this project, you will implement a program that lets the user play Hunt The Wumpus!

The layout of the cave rooms is specified in a text file. The first line of the text file gives the number of rooms in the caves (your program should handle any number of rooms). Each room is described on two lines: the first gives the room number, the room numbers of the three adjacent rooms (there are always 3); the second gives a string that describes the room.

Put this cave layout (or one in a similar format) into a text file. Your program should have two files with a minimum of two classes: one file/class to represent a single room, and a second file/class, with a main(), that plays the game and uses an array of room objects to hold the cave layout. One of the first things your program should do is open and read the layout file and put the information into your array of rooms.

Your program should then pick random numbers to figure out where to place the Wumpus, the two spider rooms (in two different rooms), and the two bottomless pits (in two different rooms). Make sure nothing ends up in room #1, as that is where the player starts, and don't put spiders, the wumpus, or a pit in the same room together. (That means any cave layout needs at least 6 rooms - room #1, the wumpus lair, and four rooms for obstacles.)

#### Jerry Tic Tac Toe

You are to write an interactive Java program that plays Jerry-Tac-Toe with the user.

This game is similar to Tic-Tac-Toe. The players, X and O, take turns making moves, and the first to place three of their symbols in a row wins. If neither wins and all places are filled, the game is a draw.
The difference between standard Tic-Tac-Toe and Jerry-Tac-Toe is that the board is different; there is a picture of it on the right. Here you can get three in a row using 1-2-3, 1-5-9, 1-4-8, 2-4-7, and so forth. 2-5-8 is not a winning combination (there is no line), and neither is 2-4-8 (the line is not straight).

Your program should play the user. The user should be allowed to choose whether to go first or second. Your program should draw the board on the screen and draw the moves graphically. You can have the user specify moves either by entering the numbers of the positions (with buttons or a textfield) or by using the mouse. When someone has won or all 9 places are filled, the game should stop and declare the outcome. The user should have the option to start a new game or quit.

Please also note that, to receive full credit on this assignment, it is not necessary for your program to play well; it is sufficient for it to play legally.
