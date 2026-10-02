#include "HashTableArray.h"

// Honor Pledge:
//
// I pledge that I have neither given nor
// received any help on this assignment.
//
// rjmeyer

//constructors 
HashTableArray::HashTableArray(): size_(0), entry_(nullptr), linear_(false), reHash_(false) 
{
	
}

HashTableArray::HashTableArray(int size) : size_(size), entry_(new HashEntry[size]), linear_(false), reHash_(false) 
{
	
}
	
HashTableArray::HashTableArray(const HashTableArray & hashArray) : size_(hashArray.size_), entry_(nullptr), linear_(false), reHash_(hashArray.reHash_) 
{ 
	linear_ = hashArray.linear_; 
	entry_ = new HashEntry[size_];
	for(int i = 0; i < size_; i++)
	{
		entry_[i] = hashArray.entry_[i]; 
	}
}	
		
//virtual destructor
HashTableArray::~HashTableArray()
{
	delete [] entry_; 
}	
		
//accessor methods 
HashEntry * HashTableArray::getEntry()
{
	return entry_; 
}

int HashTableArray::getSize()
{
	return size_; 
}

bool HashTableArray::getReHash()
{
	return reHash_; 
}
		
void HashTableArray::setEntry(HashEntry * entry)
{
	entry_ = entry; 
}
void HashTableArray::setSize(int size)
{
	size_ = size; 
	
	delete [] entry_; 
	entry_ = new HashEntry[size_]; 
}

void HashTableArray::setProbingType(bool linear)
{
	linear_ = linear; 
}

void HashTableArray::setReHash(bool reHash)
{
	reHash_ = reHash; 
}
		
//hash methods 
void HashTableArray::insert(int key, int value)
{
	int position = key % size_; 
	
	if(entry_[position].getStatus() != 1) 
	{
		entry_[position].setKey(key); 
		entry_[position].setValue(value); 
		entry_[position].setStatus(HashEntry::OCCUPIED); 
	}else{ 
		if(linear_)
		{
			bool stop = false; 
			int i = 0; 
			if(position + 1 != size_)
			{
				i = position + 1; 
			}
			
			while(!stop)
			{	
		
			
				if(entry_[i].getStatus() != 1)
				{
					entry_[i].setKey(key); 
					entry_[i].setValue(value); 
					entry_[i].setStatus(HashEntry::OCCUPIED); 
					stop = true; 
				}
				
				i++; 
				
				if(i == size_)
				{
					i = 0; 
				}
			}
		}else{
			bool stop = false; 
			int quadratic = 1; 
			int i = position+quadratic; 
			if(i >= size_) 
			{
				i = i - size_; 
			}
			
			while(!stop)
			{	
				if(entry_[i].getStatus() != 1)
				{
					entry_[i].setKey(key); 
					entry_[i].setValue(value); 
					entry_[i].setStatus(HashEntry::OCCUPIED); 
					stop = true; 
				}
				quadratic++; 
				i = position + (quadratic*quadratic); 
				
				
				if(i >= size_)
				{
					i = i - size_; 
				}
			}
		}
	}
	
}


int HashTableArray::search(int key)
{
	//first look in the position 
	int position = key % size_; 
	if(entry_[position].getKey() == key)
	{ 
		return entry_[position].getValue(); 
	}else if(linear_){
		bool stop = false; 
		int i = 0; 
		if(position + 1 != size_)
		{
			i = position + 1; 
		}
		
		while(!stop)
		{	
			if(entry_[i].getKey() == key)
			{
				stop = true; 
				return entry_[i].getValue(); 
			}else if(entry_[i].getStatus() == 0){
				stop = true; 
			}
			
			i++; 
			
			if(i == size_)
			{
				i = 0; 
			}
		}
	
		return -1;
	}else{ 
		bool stop = false; 
		int quadratic = 1; 
		int i = position+quadratic; 
		if(i >= size_) 
		{
			i = i - size_; 
		}
		
		while(!stop)
		{	
			if(entry_[i].getKey() == key)
			{
				stop = true;
				return entry_[i].getValue(); 
			}else if(entry_[i].getStatus() == 0){
				stop = true; 
			}
			
			quadratic++; 
			i = position + (quadratic*quadratic); 
			
			
			if(i >= size_)
			{
				i = i - size_; 
			}
		}
		
		return -1; 
	}
}

void HashTableArray::remove(int key)
{
	//first look in the position 
	int position = key % size_; 
	if(entry_[position].getKey() == key)
	{
		entry_[position].setStatus(HashEntry::REMOVED); 

	}else if(linear_){
		bool stop = false; 
		int i = 0; 
		if(position + 1 != size_)
		{
			i = position + 1; 
		}
		
		while(!stop)
		{	
			if(entry_[i].getKey() == key)
			{
				stop = true;
				entry_[i].setStatus(HashEntry::REMOVED);
			}else if(entry_[i].getStatus() == 0){
				stop = true; 
			}
			
			i++; 
			
			if(i == size_)
			{
				i = 0; 
			}
		}
	
	}else{ 
		bool stop = false; 
		int quadratic = 1; 
		int i = position+quadratic; 
		if(i >= size_) 
		{
			i = i - size_; 
		}
		
		while(!stop)
		{	
			if(entry_[i].getKey() == key)
			{
				stop = true; 
				entry_[i].setStatus(HashEntry::REMOVED);
			}else if(entry_[i].getStatus() == 0){
				stop = true; 
			}
			
			quadratic++; 
			i = position + (quadratic*quadratic); 
			
			
			if(i >= size_)
			{
				i = i - size_; 
			}
		}
 
	}
}

void HashTableArray::print()
{
	std::cout << "********************" << std::endl; 
	
	for(int i = 0; i < size_; i++)
	{
		std::cout << "[" << i << "]: "; 
		if(entry_[i].getStatus() == 1)
		{
			std::cout << entry_[i].getKey(); 
		}
		std::cout << std::endl;
	}
	
	std::cout << "********************" << std::endl; 
}