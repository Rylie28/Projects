#ifndef DOUBLELINKEDLIST_H
#define DOUBLELINKEDLIST_H

#include "LinkedList.h"
#include "HashEntry.h"

// Honor Pledge:
//
// I pledge that I have neither given nor
// received any help on this assignment.
//
// rjmeyer

class DoubleLinkedList : public LinkedList
{
	public: 
		DoubleLinkedList(); 
		virtual ~DoubleLinkedList(); 
		virtual void printList();
		void remove(HashEntry data); 
		int find(int key); 
		
		void insertLinkedNode(LinkedNode * node, HashEntry data);
		void insertAfterLinkedNode(LinkedNode * node, HashEntry data);
		void insertBeforeLinkedNode(LinkedNode * node, HashEntry data); 

}; 
#endif