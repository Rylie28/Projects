#ifndef NODE_H
#define NODE_H

#include "HashEntry.h"

// Honor Pledge:
//
// I pledge that I have neither given nor
// received any help on this assignment.
//
// rjmeyer

class Node
{
	public: 
		Node(HashEntry data); 
		virtual ~Node(); 
		virtual HashEntry getValue() const; 
		
	private:
		HashEntry data_; 
		
	protected: 
		Node() {}

}; 
#endif