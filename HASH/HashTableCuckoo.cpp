#include "HashTableCuckoo.h"

// Honor Pledge:
//
// I pledge that I have neither given nor
// received any help on this assignment.
//
// rjmeyer

HashTableCuckoo::HashTableCuckoo() : size_(0), entry_(nullptr), entry2(nullptr), reHash_(false)
{

}

HashTableCuckoo::HashTableCuckoo(int size) : size_(size), entry_(new HashEntry[size]), entry2(new HashEntry[size]), reHash_(false)
{

}

HashTableCuckoo::HashTableCuckoo(const HashTableCuckoo & cuckoo) : size_(cuckoo.size_), entry_(nullptr), entry2(nullptr), reHash_(cuckoo.reHash_)
{
	for(int i = 0; i < size_; i++)
	{
		entry_[i] = cuckoo.entry_[i]; 
		entry2[i] = cuckoo.entry2[i]; 
	}
} 

HashTableCuckoo::~HashTableCuckoo()
{
	delete [] entry_; 
	delete [] entry2; 
}
		
HashEntry * HashTableCuckoo::getTable1()
{
	return entry_; 
}

HashEntry * HashTableCuckoo::getTable2()
{
	return entry2; 
}

int HashTableCuckoo::getSize()
{
	return size_; 
}

bool HashTableCuckoo::getReHash()
{
	return reHash_; 
}
		
void HashTableCuckoo::setTable1(HashEntry * entry)
{
	entry_ = entry; 
}

void HashTableCuckoo::setTable2(HashEntry * entry)
{
	entry2 = entry; 
}
	
void HashTableCuckoo::setSize(int size)
{
	size_ = size; 
	
	delete [] entry_;
	delete [] entry2; 
	entry_ = new HashEntry[size_];
	entry2 = new HashEntry[size_]; 
}

void HashTableCuckoo::setReHash(bool reHash)
{
	reHash_ = reHash; 
}
		
void HashTableCuckoo::insert(int key, int value)
{
	//variable that will hold the key bouncing around 
	//HashEntry temp; 
	bool stop = false; 
	int position = 0; 
	std::vector<int> keys; 
	
	while(!stop)
	{
		position = key % size_; 
		
		if(entry_[position].getStatus() != 1)
		{
			entry_[position].setKey(key);
			entry_[position].setValue(value); 
			entry_[position].setStatus(HashEntry::OCCUPIED);
			
			break;
		}else{
			int tempKey = entry_[position].getKey(); 
			int tempValue = entry_[position].getValue();  
			
			entry_[position].setKey(key);
			entry_[position].setValue(value); 
			entry_[position].setStatus(HashEntry::OCCUPIED);
			
			key = tempKey; 
			value = tempValue; 
			
			for(int i = 0; i < keys.size(); i++)
			{
				if(keys[i] == key)
				{
					std::cout << "Encountered a Cycle" << std::endl; 
					std::cout << "key unposition: " << key << std::endl; 
					reHash_ = true; 
					stop = true; 
				}
			}
			
			keys.push_back(key); 
		}
		
		position = (key/size_) % size_; 
		
		if(entry2[position].getStatus() != 1)
		{
			entry2[position].setKey(key);
			entry2[position].setValue(value);
			entry2[position].setStatus(HashEntry::OCCUPIED);

			break; 
		}else{ 
			int tempKey = entry2[position].getKey(); 
			int tempValue = entry2[position].getValue(); 
			
			entry2[position].setKey(key);
			entry2[position].setValue(value); 
			entry2[position].setStatus(HashEntry::OCCUPIED);
			
			key = tempKey; 
			value = tempValue; 
			
			for(int i = 0; i < keys.size(); i++)
			{
				if(keys[i] == key)
				{
					std::cout << "Encountered a Cycle" << std::endl; 
					std::cout << "key unposition: " << key << std::endl; 
					reHash_ = true; 
					stop = true;  
				}
			}
			
			keys.push_back(key); 
		}
	}
	
	//check for a cycle --> hits a key it already tried to insert
	//switch to a while loop instead of recursion so I can use an array of moved values
	//depends on the boolean that checks if it doesn't need to continue ping ponging back and forth
	
	//loops until it finds an empty spot or hits a cycle
		
}

int HashTableCuckoo::search(int key)
{
	//only need to search in two places 
	//search first in entry_ --> key%size_
	//if not there then search entry2_ --> (key/size_)%size_ 
	//if not there then it doesn't exist
	int position = key % size_; 
	int position2 = (key/size_) % size_;
	
	if(entry_[position].getKey() == key)
	{
		return entry_[position].getValue();  
	}else if(entry2[position2].getKey() == key)
	{
		return entry2[position2].getValue(); 
	}else{
		return -1; 
	}
	
}

void HashTableCuckoo::remove(int key)
{
	//look in the two different places 
	//entry_ --> key%size_ 
	// if it's there change to removed 
	//else check entry2_ --> (key/size_)%size_ 
	// change to removed if their 
	int position = key % size_; 
	int position2 = (key/size_) % size_;
	
	if(entry_[position].getKey() == key)
	{
		entry_[position].setStatus(HashEntry::REMOVED); 
	}else if(entry2[position2].getKey() == key)
	{
		entry2[position2].setStatus(HashEntry::REMOVED); 
	}else{ 
		std::cout << "Invalid Key! Key " << key << " not found in table" << std::endl; 
	} //if it can't be found then return invalid key
}

void HashTableCuckoo::print()
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
	std::cout << std::endl; 
	std::cout << "********************" << std::endl; 
	
	for(int i = 0; i < size_; i++)
	{
		std::cout << "[" << i << "]: "; 
		if(entry2[i].getStatus() == 1)
		{
			std::cout << entry2[i].getKey(); 
		}
		std::cout << std::endl;
	}
	
	std::cout << "********************" << std::endl; 
}