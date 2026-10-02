#include "LinkedList.h"

// Honor Pledge:
//
// I pledge that I have neither given nor
// received any help on this assignment.
//
// rjmeyer

LinkedList::LinkedList() : head_(nullptr), tail_(nullptr)
{
	
}

LinkedList::LinkedList(const LinkedList &node) : head_(nullptr), tail_(nullptr)
{
	//deep copy
	LinkedNode * temp = node.head_; 
	while(temp != nullptr)
	{
		insert(temp->getValue()); 
		temp = temp->getNextLinkedNode(); 
	} 
}

LinkedList::~LinkedList()
{
	//uses recursion to delete ptr 
	if(head_ != nullptr)
	{
		delete head_;
	}
}

bool LinkedList::isEmpty()
{
	if(head_ == nullptr)
	{
		return true;
	}
	
	return false; 
}

int LinkedList::getLength()
{
	int count = 0; 
	
	//if list is empty
	if(isEmpty())
	{
		 return count; 
	}
	
	//traverses through the list to count length
	LinkedNode * temp = head_; 
	while(temp != nullptr)
	{
		count++; 
		temp = temp->getNextLinkedNode(); 
	}
	
	return count; 
	 
}

void LinkedList::insert(HashEntry element)
{
	LinkedNode * newNode = new LinkedNode(element, nullptr, nullptr); 
	if(head_ == nullptr && tail_ == nullptr) //insert if empty
	{
		head_ = newNode; 
		tail_ = newNode; 
	} else if(head_ != nullptr && tail_ == nullptr){ //insert if head isn't empty and tail is empty
		tail_ = newNode; 
		head_->setNextLinkedNode(newNode); 
	}else{ // catch all
		tail_ ->setNextLinkedNode(newNode);
		tail_ = newNode; 
	}
	 
}

void LinkedList::printList()
{	
	if(head_ != nullptr)
	{
		LinkedNode * node = head_; 
		while(node->hasNextLinkedNode())
		{
			std::cout << node->getValue().getKey() << "->"; 
			node = node->getNextLinkedNode(); 
		}
		
		std::cout << node->getValue().getKey() <<std::endl; 
	}else{
		std::cout << "**Empty List**" << std::endl;
	}
	
}

//getter and setter methods for double linked list
LinkedNode * LinkedList::getHead()
{
	return head_; 
}

void LinkedList::setHead(LinkedNode * head)
{
	head_ = head; 
}

LinkedNode * LinkedList::getTail()
{
	return tail_; 
}

void LinkedList::setTail(LinkedNode * tail)
{
	tail_ = tail; 
}