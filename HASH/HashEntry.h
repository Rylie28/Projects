//hashentry.h
//pull from treenode.h
#ifndef HASHENTRY_H
#define HASHENTRY_H

// Honor Pledge:
//
// I pledge that I have neither given nor
// received any help on this assignment.
//
// rjmeyer
#include <iostream> 



class HashEntry
{
	public: 
		enum Status {
			EMPTY, 
			OCCUPIED, 
			REMOVED
		}; 
		
		HashEntry();   
		~HashEntry(); 
		
		int getKey();
		int getValue(); 
		Status getStatus();  

		void setKey(int key); 	
		void setValue(int value); 
		void setStatus(Status status); 
		
		
	private: 
		int key_; 
		int value_; 
		Status status_; 

};
#endif