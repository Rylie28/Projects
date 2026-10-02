import java.io.*;
import java.util.*;

public class Caves
{
    //attributes of a cave room
    public int room;
    public int adjacentOne;
    public int adjacentTwo;
    public int adjacentThree;
    public String desc;
    
    
    //constructor
    public Caves(int r, int o, int t, int th, String d)
    {
        room = r;
        adjacentOne = o;
        adjacentTwo = t;
        adjacentThree = th;
        desc = d; 
    }
    
    public Caves(Scanner g)
    {
        room = g.nextInt();
        adjacentOne = g.nextInt();
        adjacentTwo = g.nextInt();
        adjacentThree = g.nextInt();
        desc = g.nextLine();
        desc = g.nextLine();
        
        
        
    }
    
    //observers 
    public int getRoom() { return room; }
    public int getOne() { return adjacentOne; }
    public int getTwo() { return adjacentTwo; }
    public int getThree() { return adjacentThree; }
    public String getDesc(){ return desc; } 
    
    //to string method
    public String toString()
    {
        return "You are in room " + room + "\n" + desc + "\n" + "There are tunnels to rooms " + adjacentOne + ", " + adjacentTwo + ", and " + adjacentThree; 
    }
    
    
}