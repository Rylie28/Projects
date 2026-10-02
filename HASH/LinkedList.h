#ifndef LINKEDLIST_H
#define LINKEDLIST_H

#include "LinkedNode.h"
#include "HashEntry.h"
#include <iostream> 

// Honor Pledge:
//
// I pledge that I have neither given nor
// received any help on this assignment.
//
// rjmeyer

class LinkedList
{
	public:
		//constructors and destructors 
		LinkedList(); 
		~LinkedList(); 
		LinkedList(const LinkedList &list); 

		bool isEmpty(); 
		int getLength(); 
		void insert(HashEntry element); 
		virtual void printList();
		
		//accessor methods 
		LinkedNode * getHead(); 
		void setHead(LinkedNode * head); 
		LinkedNode * getTail(); 
		void setTail(LinkedNode * tail); 
		
	private:
		LinkedNode * head_; 
		LinkedNode * tail_; 

}; 
#endif