#include "HashEntry.h"
#include "HashTable.h" 

#ifndef HASHTABLEARRAY_H
#define HASHTABLEARRAY_H

#include "HashTable.h" 

// Honor Pledge:
//
// I pledge that I have neither given nor
// received any help on this assignment.
//
// rjmeyer

class HashTableArray : public HashTable
{
	public: 
		//constructors 
		HashTableArray(); 
		HashTableArray(int size); 
		HashTableArray(const HashTableArray & hashArray); 
		
		//virtual destructor
		virtual ~HashTableArray(); 
		
		//accessor methods 
		HashEntry * getEntry(); 
		int getSize(); 
		bool getReHash(); 
		
		void setEntry(HashEntry * entry); 
		void setSize(int size); 
		void setProbingType(bool linear); 
		void setReHash(bool reHash); 
		
		//hash methods 
		virtual void insert(int key, int value);
 		virtual int search(int key);
 		virtual void remove(int key);
		virtual void print();

	private: 
		HashEntry * entry_; //dynamically allocated array of HashEntries
		int size_; //size of the table
		bool linear_; 
		//keeps track if we need to rehash
		bool reHash_; 
		
}; 
#endif