#ifndef NODE_H
#define NODE_H

// Honor Pledge:
//
// I pledge that I have neither given nor
// received any help on this assignment.
//
// rjmeyer

class Node
{
	public: 
		Node(int data = -1); 
		~Node(); 
		int getValue() const; 
		void setData(int data); 
	private:
		int data_; 

}; 
#endif