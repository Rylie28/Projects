import java.io.*;
import java.util.*; 
import javax.swing.*;
import java.awt.event.*;
import java.awt.*;

class Dad extends WindowAdapter
{
  public void windowClosing(WindowEvent e)
  {
    System.out.println("The Game has closed.");
    System.exit(0); // quits the program
  }
}

public class jerryTest extends JFrame implements MouseListener
{
	
	int xlimit; 
	int ylimit; 
	int circSize; 
	int halfSize; 
	
	//colors 
    Color pale = new Color(250, 238, 231); 
    Color pink = new Color(255, 139, 167); 
    Color orange = new Color(255, 198, 199);
    Color green = new Color(195, 240, 202);
    Color brown = new Color(51, 39, 42);
	
	class board
	{
		int x, y; 
		int size; 
		String num; 
		Color color; 
		
		public board(int x, int y, int size, String num)
		{
			this.x=x; this.y=y; this.size=size; this.num=num; 
			color = orange; 
		}
		
		//set the user color when they move
		public void setUserColor(Color newcolor) { color=newcolor; }
		
		public void draw(Graphics g)
		{
			
			g.setColor(brown); 
			g.fillOval(x, y, size, size); 
	
			//inner circle
			g.setColor(color); 
			g.fillOval(x+3, y+3, size-6, size-6); 
			
			//number on the circle
			g.setColor(brown); 
			g.setFont(new Font("Bodoni MT", Font.PLAIN, 72));
			int textwidth = (int)(g.getFontMetrics().stringWidth(num));
			int textheight = (int)(g.getFontMetrics().getHeight());
			g.drawString(num, x+size/2 - textwidth/2, y+size*3/4 - textheight/4); 
			 
		}
	}
  // this part does the drawing
  class Game extends JPanel
  {
	  board [] spots; 
    public Game()
    {
		xlimit = 1600;
		ylimit = 925; 
		circSize = 150; 
		halfSize = circSize/2; 
		
		setSize(xlimit,ylimit);
		spots=new board[9]; 
		
		// sets up the circles
			spots[0] = new board((xlimit/4 - halfSize), (ylimit/4 - halfSize), circSize, "1"); 
			spots[1] = new board((xlimit/2 - halfSize), (ylimit/4 - halfSize), circSize, "2"); 
			spots[2] = new board((xlimit*3/4 - halfSize), (ylimit/4 - halfSize), circSize, "3"); 
			spots[3] = new board((xlimit*3/8 - halfSize), (ylimit/2 - halfSize), circSize, "4"); 
			spots[4] = new board((xlimit/2 - halfSize), (ylimit/2 - halfSize), circSize, "5"); 
			spots[5] = new board((xlimit*5/8 - halfSize), (ylimit/2 - halfSize), circSize, "6"); 
			spots[6] = new board((xlimit/4 - halfSize), (ylimit*3/4 - halfSize), circSize, "7"); 
			spots[7] = new board((xlimit/2 - halfSize), (ylimit*3/4 - halfSize), circSize, "8"); 
			spots[8] = new board((xlimit*3/4 - halfSize), (ylimit*3/4 - halfSize), circSize, "9");	
			
			
    }
	
	public void changecolor(int num, Color c)
	{
		spots[num].setUserColor(c); 
	}

    public void paintComponent(Graphics g)
    {
		g.setColor(pale); 
		g.fillRect(0,0,xlimit,ylimit);
		
		
		//lines --> need 9 lines
		g.setColor(brown); 
		Graphics2D g2 = (Graphics2D) g;
        g2.setStroke(new BasicStroke(4));
		g.drawLine(xlimit/4, ylimit/4, xlimit*3/4, ylimit*3/4);
		g.drawLine(xlimit/4, ylimit*3/4, xlimit*3/4, ylimit/4);
		g.drawLine(xlimit/4, ylimit/4, xlimit/2, ylimit*3/4);
		g.drawLine(xlimit/2, ylimit*3/4, xlimit*3/4, ylimit/4);
		g.drawLine(xlimit/4, ylimit*3/4, xlimit/2, ylimit/4);
		g.drawLine(xlimit/2, ylimit/4, xlimit*3/4, ylimit*3/4);
		g.drawLine(xlimit/4, ylimit/4, xlimit*3/4, ylimit/4);
		g.drawLine(xlimit*3/8, ylimit/2, xlimit*5/8, ylimit/2);
		g.drawLine(xlimit/4, ylimit*3/4, xlimit*3/4, ylimit*3/4);
		
		for(int i = 0; i<spots.length; i++)
			spots[i].draw(g);
		
		if(hasWon(1))
		{
			g.setColor(brown); 
			g.setFont(new Font("Bodoni MT", Font.PLAIN, 48));
			g.drawString("The computer has won!", 575, ylimit/8); 
		}else if(hasWon(2))
		{
			g.setColor(brown); 
			g.setFont(new Font("Bodoni MT", Font.PLAIN, 48));
			g.drawString("The user has won!", 625, ylimit/8); 
		}else if(gameOver())
		{
			g.setColor(brown); 
			g.setFont(new Font("Bodoni MT", Font.PLAIN, 48));
			g.drawString("The board is full", 625, ylimit/8); 
		}
    }
  }

  Game tic;

  JButton change, move, restart;
  JTextField circlenumber;
  int Computernum; 
  int [] moved = new int[9];
  boolean firstMoved;
  int [] ComMoves = new int[25];
  int numMoves = 0; 
  // EMPTY = 0; 
  //COMPUTER-MOVE = 1; 
  //HUMAN-MOVE = 2; 
  
	public void mouseClicked(MouseEvent e) { }
 
	public void mousePressed(MouseEvent e) 
	{
		//which button was pushed?
	  if(e.getSource() == change)
	  {
		int cn; 
		String s = circlenumber.getText(); 
		cn = Integer.parseInt(s); 
		tic.changecolor(cn-1, pink);
		moved[cn-1] = 2; 
		
		if(gameOver())
		{  }else{ 
			chooseMove(); 
			gameOver(); 
		}
		
		
	  }
	  
	  if(e.getSource() == move)
		  chooseMove(); 
	  
	  if(e.getSource() == restart)
	  {
		  //restart the game
		for(int i = 0; i<9; i++)
			tic.changecolor(i, orange);
		for(int i = 0; i<moved.length; i++)
			moved[i] = 0; 
	  }
		repaint(); 
	}
 
	public void mouseReleased(MouseEvent e) { }
 
 
 
	public void mouseEntered(MouseEvent e) 
	{ 
		if(e.getSource()==change) {  change.setBackground(green); }
		if(e.getSource()==move) {  move.setBackground(green); }
		if(e.getSource()==restart) {  restart.setBackground(green); }
	}
 
 
	public void mouseExited(MouseEvent e) 
	{ 
		if(e.getSource()== change) { change.setBackground(pink); }
		if(e.getSource()== move) { move.setBackground(pink); }
		if(e.getSource()== restart) { restart.setBackground(pink); }
	}

	//computer first chooses a random move and then depending on that move picks an open second move that would help it win. 
	//if the user is close to winning the computer will try to block them first
	//if the computer can't do either of those then it picks another random move
	
	public void randomMove()
	{
		Computernum = (int)(Math.random()*8); 
		
	
		firstMoved = false; 
		while(!firstMoved)
		{
			if(moved[Computernum] != 0)
				Computernum = (int)(Math.random()*8); 
			else
			{ 
				tic.changecolor(Computernum, green);
				moved[Computernum] = 1; 
				firstMoved = true; 
				ComMoves[numMoves] = Computernum; 
				numMoves++; 
				
				
			}
		}
	}

	public void chooseMove()
	{
	
		if(!firstMoved)
		{
			randomMove();  
		}else
		{
		boolean hasMoved = false; 
		
			while(!hasMoved)
			{
				//user is about to win 
				//move 123
				if((moved[0] == 2 && moved[1] == 2) || (moved[0] == 2 && moved[2] == 2) || (moved[1] == 2 && moved[2] == 2))
				{
					if(moved[0] == 2 && moved[1] == 2 && moved[2] == 0)
					{
						tic.changecolor(2, green); 
						moved[2] = 1;
						ComMoves[numMoves + 1] = 2; 
						numMoves++;
						return;
					}else if(moved[0] == 2 && moved[2] == 2 && moved[1] == 0)
					{
						tic.changecolor(1, green); 
						moved[1] = 1;
						ComMoves[numMoves + 1] = 1; 
						numMoves++;
						return;
					}else if(moved[1] == 2 && moved[2] == 2 && moved[0] == 0)
					{
						tic.changecolor(0, green); 
						moved[0] = 1;
						ComMoves[numMoves + 1] = 0; 
						numMoves++;
						return;
					}
				}
				//move 148
				if((moved[0] == 2 && moved[3] == 2) || (moved[0] == 2 && moved[7] == 2) || (moved[3] == 2 && moved[7] == 2))
				{
					if(moved[0] == 2 && moved[3] == 2 && moved[7] == 0)
					{
						tic.changecolor(7, green); 
						moved[7] = 1;
						ComMoves[numMoves + 1] = 7; 
						numMoves++;
						return;
					}else if(moved[0] == 2 && moved[7] == 2 && moved[3] == 0)
					{
						tic.changecolor(3, green); 
						moved[3] = 1;
						ComMoves[numMoves + 1] = 3; 
						numMoves++;
						return;
					}else if(moved[3] == 2 && moved[7] == 2 && moved[0] == 0)
					{
						tic.changecolor(0, green); 
						moved[0] = 1;
						ComMoves[numMoves + 1] = 0; 
						numMoves++;
						return;
					}
				}
				//move 159
				if((moved[0] == 2 && moved[4] == 2) || (moved[0] == 2 && moved[8] == 2) || (moved[4] == 2 && moved[8] == 2))
				{
					if(moved[0] == 2 && moved[4] == 2 && moved[8] == 0)
					{
						tic.changecolor(8, green); 
						moved[8] = 1;
						ComMoves[numMoves + 1] = 8; 
						numMoves++;
						return;
					}else if(moved[0] == 2 && moved[8] == 2 && moved[4] == 0)
					{
						tic.changecolor(4, green); 
						moved[4] = 1;
						ComMoves[numMoves + 1] = 4; 
						numMoves++;
						return;
					}else if(moved[4] == 2 && moved[8] == 2 && moved[0] == 0)
					{
						tic.changecolor(0, green); 
						moved[0] = 1;
						ComMoves[numMoves + 1] = 0; 
						numMoves++;
						return;
					}
				}
				//move 247
				if((moved[1] == 2 && moved[3] == 2) || (moved[1] == 2 && moved[6] == 2) || (moved[3] == 2 && moved[6] == 2))
				{
					if(moved[1] == 2 && moved[3] == 2 && moved[6] == 0)
					{
						tic.changecolor(6, green); 
						moved[6] = 1;
						ComMoves[numMoves + 1] = 6; 
						numMoves++;
						return;
					}else if(moved[1] == 2 && moved[6] == 2 && moved[3] == 0)
					{
						tic.changecolor(3, green); 
						moved[3] = 1;
						ComMoves[numMoves + 1] = 3; 
						numMoves++;
						return;
					}else if(moved[3] == 2 && moved[6] == 2 && moved[1] == 0)
					{
						tic.changecolor(1, green); 
						moved[1] = 1;
						ComMoves[numMoves + 1] = 1; 
						numMoves++;
						return;
					}
				}
				//move 269
				if((moved[1] == 2 && moved[5] == 2) || (moved[1] == 2 && moved[8] == 2) || (moved[5] == 2 && moved[8] == 2))
				{
					if(moved[1] == 2 && moved[5] == 2 && moved[8] == 0)
					{
						tic.changecolor(8, green); 
						moved[8] = 1;
						ComMoves[numMoves + 1] = 8; 
						numMoves++;
						return;
					}else if(moved[1] == 2 && moved[8] == 2 && moved[5] == 0)
					{
						tic.changecolor(5, green); 
						moved[5] = 1;
						ComMoves[numMoves + 1] = 5; 
						numMoves++;
						return;
					}else if(moved[5] == 2 && moved[8] == 2 && moved[1] == 0)
					{
						tic.changecolor(1, green); 
						moved[1] = 1;
						ComMoves[numMoves + 1] = 1; 
						numMoves++;
						return;
					}
				}
				//move 368
				if((moved[2] == 2 && moved[5] == 2) || (moved[2] == 2 && moved[7] == 2) || (moved[5] == 2 && moved[7] == 2))
				{
					if(moved[2] == 2 && moved[5] == 2 && moved[7] == 0)
					{
						tic.changecolor(7, green); 
						moved[7] = 1;
						ComMoves[numMoves + 1] = 7; 
						numMoves++;
						return;
					}else if(moved[2] == 2 && moved[7] == 2 && moved[5] == 0)
					{
						tic.changecolor(5, green); 
						moved[5] = 1;
						ComMoves[numMoves + 1] = 5; 
						numMoves++;
						return;
					}else if(moved[5] == 2 && moved[7] == 2 && moved[2] == 0)
					{
						tic.changecolor(2, green); 
						moved[2] = 1;
						ComMoves[numMoves + 1] = 2; 
						numMoves++;
						return;
					}
				}
				//move 357
				if((moved[2] == 2 && moved[4] == 2) || (moved[2] == 2 && moved[6] == 2) || (moved[4] == 2 && moved[6] == 2))
				{
					if(moved[2] == 2 && moved[4] == 2 && moved[6] == 0)
					{
						tic.changecolor(6, green); 
						moved[6] = 1;
						ComMoves[numMoves + 1] = 6; 
						numMoves++;
						return;
					}else if(moved[2] == 2 && moved[6] == 2 && moved[4] == 0)
					{
						tic.changecolor(4, green); 
						moved[4] = 1;
						ComMoves[numMoves + 1] = 4; 
						numMoves++;
						return;
					}else if(moved[4] == 2 && moved[6] == 2 && moved[2] == 0)
					{
						tic.changecolor(2, green); 
						moved[2] = 1;
						ComMoves[numMoves + 1] = 2; 
						numMoves++;
						return;
					}
				}
				//move 456
				if((moved[3] == 2 && moved[4] == 2) || (moved[3] == 2 && moved[5] == 2) || (moved[4] == 2 && moved[5] == 2))
				{
					if(moved[3] == 2 && moved[4] == 2 && moved[5] == 0)
					{
						tic.changecolor(5, green); 
						moved[5] = 1;
						ComMoves[numMoves + 1] = 5; 
						numMoves++;
						return;
					}else if(moved[3] == 2 && moved[5] == 2 && moved[4] == 0)
					{
						tic.changecolor(4, green); 
						moved[4] = 1;
						ComMoves[numMoves + 1] = 4; 
						numMoves++;
						return;
					}else if(moved[4] == 2 && moved[5] == 2 && moved[3] == 0)
					{
						tic.changecolor(3, green); 
						moved[3] = 1;
						ComMoves[numMoves + 1] = 3; 
						numMoves++;
						return;
					}
				}
				//move 789
				if((moved[6] == 2 && moved[7] == 2) || (moved[6] == 2 && moved[8] == 2) || (moved[7] == 2 && moved[8] == 2))
				{
					if(moved[6] == 2 && moved[7] == 2 && moved[8] == 0)
					{
						tic.changecolor(8, green); 
						moved[8] = 1;
						ComMoves[numMoves + 1] = 8; 
						numMoves++;
						return;
					}else if(moved[6] == 2 && moved[8] == 2 && moved[7] == 0)
					{
						tic.changecolor(7, green); 
						moved[7] = 1;
						ComMoves[numMoves + 1] = 7; 
						numMoves++;
						return;
					}else if(moved[7] == 2 && moved[8] == 2 && moved[6] == 0)
					{
						tic.changecolor(6, green); 
						moved[6] = 1;
						ComMoves[numMoves + 1] = 6; 
						numMoves++;
						return;
					}
				}
				int m = ComMoves[numMoves-1]; 
				//if computer chooses 1 
				if(m == 0)
				{
					if(moved[1] != 0 && moved[3] != 0)
					{
						tic.changecolor(4, green); 
						moved[4] = 1;
						ComMoves[numMoves + 1] = 4; 
						numMoves++; 
						hasMoved = true;
					}else if(moved[1] != 0 && moved[4] != 0)
					{
						tic.changecolor(3, green); 
						moved[3] = 1;
						ComMoves[numMoves + 1] = 3; 
						numMoves++; 
						hasMoved = true;
					}else if(moved[3] != 0 && moved[4] != 0)
					{
						tic.changecolor(1, green);
						moved[1] = 1;
						ComMoves[numMoves + 1] = 1; 
						numMoves++;
						hasMoved = true;
					}else{
						randomMove();
						hasMoved = true;
					} 
				}
				//if computer chooses 3
				if(m == 2)
				{
					if(moved[1] != 0 && moved[4] != 0)
					{
						tic.changecolor(5, green); 
						moved[5] = 1;
						ComMoves[numMoves + 1] = 5; 
						numMoves++; 
						hasMoved = true;
					}else if(moved[1] != 0 && moved[5]!= 0)
					{
						tic.changecolor(4, green); 
						moved[4] = 1;
						ComMoves[numMoves + 1] = 4; 
						numMoves++; 
						hasMoved = true;
					}else if(moved[4] != 0 && moved[5] != 0)
					{
						tic.changecolor(1, green);
						moved[1] = 1;
						ComMoves[numMoves + 1] = 1; 
						numMoves++;
						hasMoved = true;
					}else{
						randomMove();
						hasMoved = true;
					}
				}
				//if computer chooses 7
				if(m == 6)
				{
					if(moved[3] != 0 && moved[4] != 0)
					{
						tic.changecolor(7, green); 
						moved[7] = 1;
						ComMoves[numMoves + 1] = 7; 
						numMoves++; 
						hasMoved = true;
					}else if(moved[3] != 0 && moved[7] != 0)
					{
						tic.changecolor(4, green); 
						moved[4] = 1;
						ComMoves[numMoves + 1] = 4; 
						numMoves++; 
						hasMoved = true;
					}else if(moved[4] != 0 && moved[7] != 0)
					{
						tic.changecolor(3, green);
						moved[3] = 1;
						ComMoves[numMoves + 1] = 3; 
						numMoves++;
						hasMoved = true;
					}else{
						randomMove();
						hasMoved = true;
					} 
				}
				//if computer chooses 9
				if(m == 8)
				{
					if(moved[4] != 0 && moved[5] != 0)
					{
						tic.changecolor(7, green); 
						moved[7] = 1;
						ComMoves[numMoves + 1] = 7; 
						numMoves++; 
						hasMoved = true;
					}else if(moved[4] != 0 && moved[7] != 0)
					{
						tic.changecolor(5, green); 
						moved[5] = 1;
						ComMoves[numMoves + 1] = 5; 
						numMoves++; 
						hasMoved = true;
					}else if(moved[5] != 0 && moved[7] != 0)
					{
						tic.changecolor(4, green);
						moved[4] = 1;
						ComMoves[numMoves + 1] = 4; 
						numMoves++;
						hasMoved = true;
					}else{
						randomMove();
						hasMoved = true;
					} 
				}
				//if the computer chooses 4 or 6
				if(m == 3 || m == 5)
				{
					if(moved[7] != 0 && moved[4] != 0)
					{
						tic.changecolor(1, green); 
						moved[1] = 1;
						ComMoves[numMoves + 1] = 1; 
						numMoves++; 
						hasMoved = true;
					}else if(moved[1] != 0 && moved[7] != 0)
					{
						tic.changecolor(4, green); 
						moved[4] = 1;
						ComMoves[numMoves + 1] = 4; 
						numMoves++; 
						hasMoved = true;
					}else if(moved[1] != 0 && moved[4] != 0)
					{
						tic.changecolor(7, green);
						moved[7] = 1;
						ComMoves[numMoves + 1] = 7; 
						numMoves++;
						hasMoved = true;
					}else{
						randomMove();
						hasMoved = true;
					}
				}
				//if the computer chooses 2, 8, or 5
				if(m == 1 || m == 7 || m == 4)
				{
					if(moved[5] != 0)
					{
						tic.changecolor(3, green);
						moved[3] = 1;
						ComMoves[numMoves + 1] = 3; 
						numMoves++; 
						hasMoved = true;
					}else if(moved[3] != 0)
					{
						tic.changecolor(5, green);
						moved[5] = 1;
						ComMoves[numMoves + 1] = 5; 
						numMoves++; 
						hasMoved = true;
					}else 
					{
						randomMove(); 
						hasMoved = true;
					}
				}
			}
		
				
		}
	
	}
  
  public boolean gameOver()
  {
	  //boolean for if the game is over 
	  boolean over = false; 
	  //check if computer won
	  if(hasWon(1))
	  {
		  over = true;  
	  }
	  //check if human won
	  if(hasWon(2))
	  {
		  over = true; 
	  }
	  //check if the board is full
	  if(boardFull())
	  {
		  over = true;
	  }
	  
	  return over; 
  }  
  
  public boolean boardFull()
  {
	boolean b = true; 
	for(int i = 1; i<moved.length; i++)
	{
		if(moved[i] == 0) 
			b = false; 
	}
	
	return b; 
  }
  
  public boolean hasWon(int player)
  {
	boolean win = false; 
	if(moved[0] == player && moved[1] == player && moved[2] == player)
		win = true; 
	else if(moved[0] == player && moved[3]== player && moved[7] == player)
		win = true; 
	else if(moved[0] == player && moved[4] == player && moved[8] == player)
		win = true; 
	else if(moved[1] == player && moved[3] == player && moved[6] == player)
		win = true; 
	else if(moved[1] == player && moved[5] == player && moved[8] == player)
		win = true; 
	else if(moved[2] == player && moved[4] == player && moved[6] == player)
		win = true; 
	else if(moved[2] == player && moved[5] == player && moved[7] == player)
		win = true; 
	else if(moved[3] == player && moved[4] == player && moved[5] == player)
		win = true; 
	else if(moved[6] == player && moved[7] == player && moved[8] == player)
		win = true; 
	else 
		win = false; 
	
	return win; 
	  
  }

  public jerryTest()
  {
    setTitle("Jerry Tic Tac Toe");
    addWindowListener( new Dad() );
    setSize(1600,1025);

    Container glass=getContentPane();
    glass.setLayout( new BorderLayout() );
	
	change = new JButton("MOVE"); 
	change.addMouseListener(this);
	change.setFont(new Font("Bodoni MT", Font.BOLD, 24));
	change.setBackground(pink);
	change.setForeground(brown);
	
	move = new JButton("Computer First"); 
	move.addMouseListener(this);
	move.setFont(new Font("Bodoni MT", Font.BOLD, 16));
	move.setBackground(pink);
	move.setForeground(brown);
	
	restart = new JButton("REPLAY"); 
	restart.addMouseListener(this);
	restart.setFont(new Font("Bodoni MT", Font.BOLD, 16));
	restart.setBackground(pink);
	restart.setForeground(brown);
	
	circlenumber = new JTextField("0");
	circlenumber.setFont(new Font("Bodoni MT", Font.PLAIN, 24));

    tic=new Game();
	
	JPanel bottom = new JPanel(); 
	bottom.setLayout(new BorderLayout()); 
	JPanel two = new JPanel(); 
	two.setLayout(new BorderLayout()); 
	
	two.add(move, "North"); 
	two.add(restart, "South");
	
	bottom.add(change, "West"); 
	bottom.add(two, "East"); 
	bottom.add(circlenumber, "Center"); 

    glass.add(tic,"Center");
    glass.add(bottom, "South");

    repaint();
    setVisible(true);
  }

  public static void main(String [] args)
  { 
    jerryTest JTTT=new jerryTest();
  }
}
