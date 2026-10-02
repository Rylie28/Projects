#include "HashTableChaining.h"

// Honor Pledge:
//
// I pledge that I have neither given nor
// received any help on this assignment.
//
// rjmeyer

HashTableChaining::HashTableChaining() : size_(0), entry_(nullptr), reHash_(false) 
{
	
}

HashTableChaining::HashTableChaining(int size) : size_(size), entry_(new DoubleLinkedList[size]), reHash_(false) 
{
	
}

HashTableChaining::HashTableChaining(const HashTableChaining & chain) : size_(chain.size_), entry_(nullptr), reHash_(chain.reHash_) 
{
	for(int i = 0; i < size_; i++)
	{
		entry_[i] = chain.entry_[i]; 
	}
}

HashTableChaining::~HashTableChaining()
{
	delete [] entry_; 
}
		
int HashTableChaining::getSize()
{
	return size_; 
}

DoubleLinkedList * HashTableChaining::getEntry()
{
	return entry_; 
}

bool HashTableChaining::getReHash()
{
	return reHash_; 
}
		
void HashTableChaining::setSize(int size)
{
		size_ = size; 
		delete [] entry_; 
		entry_ = new DoubleLinkedList[size_]; 
}

void HashTableChaining::setEntry(DoubleLinkedList * entry)
{
	entry_ = entry; 
}

void HashTableChaining::setReHash(bool reHash)
{
	reHash_ = reHash; 
}
		
void HashTableChaining::insert(int key, int value)
{
	int position = key % size_; 
	
	HashEntry temp; 
	temp.setKey(key); 
	temp.setValue(value); 
	temp.setStatus(HashEntry::OCCUPIED); 
	
	entry_[position].insertLinkedNode(entry_[position].getHead(), temp); 
}

int HashTableChaining::search(int key)
{
	int position = key % size_ ; 
	
	return entry_[position].find(key); 
}

void HashTableChaining::remove(int key)
{
	int position = key % size_; 
	
	HashEntry temp; 
	temp.setKey(key); 
	temp.setValue(search(key)); 
	temp.setStatus(HashEntry::OCCUPIED); 
	
	entry_[position].remove(temp); 
}

void HashTableChaining::print()
{
	std::cout << "********************" << std::endl; 
	
	for(int i = 0; i < size_; i++)
	{
		std::cout << "[" << i << "]: "; 
		if(!entry_[i].isEmpty())
		{
			entry_[i].printList(); 
		}
		std::cout << std::endl; 
	}
	
	std::cout << "********************" << std::endl; 
}