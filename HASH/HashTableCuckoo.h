#ifndef HASHTABLECUCKOO_H
#define HASHTABLECUCKOO_H
#include "HashTable.h" 
#include "HashEntry.h"
#include <vector>

// Honor Pledge:
//
// I pledge that I have neither given nor
// received any help on this assignment.
//
// rjmeyer

class HashTableCuckoo : public HashTable
{
	public:
		HashTableCuckoo(); 
		HashTableCuckoo(int size); 
		HashTableCuckoo(const HashTableCuckoo & cuckoo);
		virtual ~HashTableCuckoo(); 
		
		HashEntry * getTable1(); 
		HashEntry * getTable2(); 
		int getSize(); 
		bool getReHash(); 
		
		void setTable1(HashEntry * entry);
		void setTable2(HashEntry * entry); 
		void setSize(int size);
		void setReHash(bool reHash); 
		
		virtual void insert(int key, int value);
		virtual int search(int key);
		virtual void remove(int key);
		virtual void print();
		
	private: 
		int size_; 
		HashEntry * entry_; //table 1
		HashEntry * entry2; //table 2
		//variable to know if we need to rehash the table because of cycle
		bool reHash_; 

}; 
#endif