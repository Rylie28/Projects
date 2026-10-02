#ifndef LINKEDNODE_H
#define LINKEDNODE_H

#include "Node.h"
#include "HashEntry.h"
#include <iostream> 

// Honor Pledge:
//
// I pledge that I have neither given nor
// received any help on this assignment.
//
// rjmeyer

class LinkedNode : public Node
{
	public: 
		LinkedNode(HashEntry data); 
		LinkedNode(const LinkedNode & node);
		LinkedNode(HashEntry data, LinkedNode * nextLinkedNode, LinkedNode *prevLinkedNode);
		~LinkedNode(); 
		
		//accessor methods for nextLinkedNode_
		LinkedNode * getNextLinkedNode(); 
		void setNextLinkedNode(LinkedNode * node);
		bool hasNextLinkedNode(); 
		
		//accessor methods for preLinkedNode_
		LinkedNode * getPrevLinkedNode();
		void setPrevLinkedNode(LinkedNode * prevLinkedNode);
		bool hasPrevLinkedNode();
	
	private: 
		LinkedNode * nextLinkedNode_; 
		LinkedNode * prevLinkedNode_; 

};
#endif