#ifndef HASHTABLECHAINING_H
#define HASHTABLECHAINING_H

#include "HashTable.h" 
#include "DoubleLinkedList.h"
#include "LinkedList.h" 

// Honor Pledge:
//
// I pledge that I have neither given nor
// received any help on this assignment.
//
// rjmeyer

class HashTableChaining : public HashTable
{
	public: 
		HashTableChaining(); 
		HashTableChaining(int size); 
		HashTableChaining(const HashTableChaining & chain); 
		virtual ~HashTableChaining(); 
		
		int getSize(); 
		DoubleLinkedList * getEntry(); 
		bool getReHash(); 
		
		void setSize(int size); 
		void setEntry(DoubleLinkedList * entry); 
		void setReHash(bool reHash); 
		
		virtual void insert(int key, int value);
		virtual int search(int key);
		virtual void remove(int key);
		virtual void print();

	private:
		DoubleLinkedList * entry_;
		int size_;
		//keeps track if we need to rehash
		bool reHash_; 
}; 
#endif