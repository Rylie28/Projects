//hashentry.cpp
//pull from treenode.cpp

// Honor Pledge:
//
// I pledge that I have neither given nor
// received any help on this assignment.
//
// rjmeyer

#include "HashEntry.h"

HashEntry::HashEntry() : key_(0), value_(0), status_(EMPTY)
{

}  

HashEntry::~HashEntry()
{
	
}
		
int HashEntry::getKey()
{
	return key_; 
}

int HashEntry::getValue()
{
	return value_; 
}

HashEntry::Status HashEntry::getStatus()
{
	return status_; 
}

void HashEntry::setKey(int key)
{
	key_ = key; 
}
	
void HashEntry::setValue(int value)
{
	value_ = value; 
}
void HashEntry::setStatus(Status status)
{
	status_ = status; 
}	