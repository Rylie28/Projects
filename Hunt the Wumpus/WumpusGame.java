import java.io.*;
import java.util.*;

public class WumpusGame {
    public static void main(String[] args) 
    throws IOException
    {
    //read the file
    Scanner gamefile=new Scanner(new FileReader("games.txt"));
    Scanner user = new Scanner(System.in);
    
    int n = gamefile.nextInt();
    Caves [] cave = new Caves[n];
    //variables for the number of spider rooms and number of wumpus rooms
    int s = gamefile.nextInt();
    int p = gamefile.nextInt();
    
    for(int i = 0; i < cave.length; i++)
    {
        
        cave[i] = new Caves(gamefile);
        //System.out.println(cave[i]); for testing
    }
    
    // create the spider rooms, pit rooms, and wumpus room
    //array of random numbers
    ArrayList<Integer> randomList = new ArrayList<Integer>();
    int size = s + p + 1;
    
    //loop to insert random numbers into an array if they aren't duplicates
    while(randomList.size() < size)
    {
        int random = (int)((Math.random()*9)+2);
        if(!randomList.contains(random)) { randomList.add(random); }
    }
    
    //initialize and set a current room variable
    int currentRoom = 1;
    int arrows = 3; 
    boolean wumpusMonster = true; 
    
    System.out.println("Welcome to HUNT THE WUMPUS");
    System.out.println(cave[currentRoom - 1]);
    System.out.println("You have " + arrows + " arrows left.");
    if(spiderChecker(cave[currentRoom - 1], s, randomList)) { System.out.println("You hear faint clicking noises"); } 
    if(pitChecker(cave[currentRoom - 1], s, p, randomList)) { System.out.println("You smell a dank odor"); }
    if(wumpusChecker(cave[currentRoom - 1], randomList.get(size-1))) { System.out.println("You smell some nasty Wumpus"); }
    
    
    //Initialize input variables before while loop
    String action;
    int roomNumber;
    int shootRoom; 
    
    //conditional loop to run the game
    while(wumpusMonster)
    {
        System.out.println("(M)ove or (S)hoot");
        action = user.next();
        
        // check which action the user wants to do
        if(action.equals("M"))
        {
            
            System.out.println("Which room");
            roomNumber = user.nextInt();
            //condition for when moving into a room with spiders, pit or the wumpus
            if((roomNumber == cave[currentRoom - 1].getOne()) || (roomNumber == cave[currentRoom-1].getTwo()) || (roomNumber == cave[currentRoom-1].getThree()))
            {
                if((!spiderRoomChecker(s, roomNumber, randomList)) && (!pitRoomChecker(s, p, roomNumber, randomList)) && (roomNumber != randomList.get(size-1)))
                {
                    currentRoom = roomNumber;
                    System.out.println(cave[currentRoom-1]);
                    System.out.println("You have " + arrows + " arrows left.");
                    if(currentRoom == 8) { 
                        System.out.println("You have found the arrow supply room");
                        arrows = 3;
                        System.out.println("You have " + arrows + " arrows left.");}
                    if(spiderChecker(cave[currentRoom - 1], s, randomList)) { System.out.println("You hear faint clicking noises"); } 
                    if(pitChecker(cave[currentRoom - 1], s, p, randomList)) { System.out.println("You smell a dank odor"); }
                    if(wumpusChecker(cave[currentRoom - 1], randomList.get(size-1))) { System.out.println("You smell some nasty Wumpus"); }
                
                }else if(spiderRoomChecker(s, roomNumber, randomList)){
                    System.out.println("SORRY YOU LOSE \nYou moved into a room with spiders and they killed you!");
                    return;
                }else if(pitRoomChecker(s, p, roomNumber, randomList)){
                    System.out.println("SORRY YOU LOSE \nYou moved into a room with a bottomless pit and fell!");
                    return;
                }else if(roomNumber == randomList.get(size - 1)){
                    System.out.println("SORRY YOU LOSE \nYou moved into the room with the Wumpus and died!");
                    return; 
                }
            }else{    
                    System.out.println("You can't get to that room from here, dummy!");
                    System.out.println("There are tunnels to rooms " + cave[currentRoom - 1].getOne() + ", " + cave[currentRoom - 1].getTwo() + ", and " + cave[currentRoom - 1].getThree());
            
                }
            
        }else if(action.equals("S"))//if user chooses to shoot an arrow
        {
            System.out.println("Which Room?");
            shootRoom = user.nextInt();
            if((shootRoom == cave[currentRoom - 1].getOne()) || (shootRoom == cave[currentRoom-1].getTwo()) || (shootRoom == cave[currentRoom-1].getThree()))
            {
                if(shootRoom != randomList.get(size-1))//the arrow misses 
                {
                    
                    System.out.println("Your arrow goes down the tunnel and is lost.");
                    arrows--;
                
                    System.out.println();
                    System.out.println(cave[currentRoom-1]);
                    System.out.println("You have " + arrows + " arrows left.");
                    if(spiderChecker(cave[currentRoom - 1], s, randomList)) { System.out.println("You hear faint clicking noises"); } 
                    if(pitChecker(cave[currentRoom - 1], s, p, randomList)) { System.out.println("You smell a dank odor"); }
                    if(wumpusChecker(cave[currentRoom - 1], randomList.get(size-1))) { System.out.println("You smell some nasty Wumpus"); }
                }else if (shootRoom == randomList.get(size-1))
                {
                    System.out.println("Your arrow goes down the tunnel and hits its mark! \nYou shot the Wumpus \nYOU WIN"); 
                    wumpusMonster = false; 
                }
            }else{ 
                System.out.println("Dummy! you can't shoot an arrow into that cave from here.");
                System.out.println("There are tunnels to rooms " + cave[currentRoom - 1].getOne() + ", " + cave[currentRoom - 1].getTwo() + ", and " + cave[currentRoom - 1].getThree());
            }
        }
    
    
    }
    
    }
    //monster checking methods
    static boolean spiderChecker(Caves c, int spiderRooms, ArrayList<Integer> r)
    {
        boolean spiderRoom = false; 
        
        for(int i = 0; i < spiderRooms; i++)
        {
            if(c.getOne() == r.get(i)) { spiderRoom = true; }
            else if(c.getTwo() == r.get(i)) { spiderRoom = true; }
            else if(c.getThree() == r.get(i)) { spiderRoom = true; }
        }
        
        return spiderRoom; 
        
    }
    static boolean spiderRoomChecker(int spiderRooms, int room, ArrayList<Integer> r)
    {
        boolean spiderRoom = false; 
        for(int i = 0; i < spiderRooms; i++)
        {
            if(room == r.get(i)) { spiderRoom = true; } 
        }
        
        return spiderRoom;
    }
    static boolean pitChecker(Caves c, int spiderRooms, int pitRooms, ArrayList<Integer> r)
    {
        boolean pitRoom = false; 
        
        for(int i = spiderRooms; i < pitRooms + spiderRooms; i++)
        {
            if(c.getOne() == r.get(i)) { pitRoom = true; }
            else if(c.getTwo() == r.get(i)) { pitRoom = true; }
            else if(c.getThree() == r.get(i)) { pitRoom = true; }
        }
        
        return pitRoom; 
    }
    static boolean pitRoomChecker(int spiderRooms, int pitRooms, int room, ArrayList<Integer> r)
    {
        boolean pit = false; 
        for(int i = spiderRooms; i < pitRooms + spiderRooms; i++)
        {
            if(room == r.get(i)) { pit = true; } 
        }
        
        return pit; 
    }
    static boolean wumpusChecker(Caves c, int wumpus)
    {
        boolean wumpusRoom = false; 
        
        if(c.getOne() == wumpus)
        {
            wumpusRoom = true; 
        }else if(c.getTwo() == wumpus)
        {
            wumpusRoom = true;
        }else if(c.getThree() == wumpus)
        {
            wumpusRoom = true; 
        }else{
            wumpusRoom = false; 
        }
        
        return wumpusRoom; 
    }
}