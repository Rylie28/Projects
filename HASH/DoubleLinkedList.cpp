#include "DoubleLinkedList.h"

// Honor Pledge:
//
// I pledge that I have neither given nor
// received any help on this assignment.
//
// rjmeyer

DoubleLinkedList::DoubleLinkedList() : LinkedList()
{
	
}

DoubleLinkedList::~DoubleLinkedList()
{
	
}

void DoubleLinkedList::printList()
{
	if(!isEmpty())
	{
		LinkedNode * currentNode = LinkedList::getHead();  
		std::cout << currentNode->getValue().getKey(); 
		while(currentNode->hasNextLinkedNode())
		{
			currentNode = currentNode->getNextLinkedNode(); 
			std::cout << "<-->" << currentNode->getValue().getKey(); 
		}
			
	}else{
		std::cout << "**Empty List**" << std::endl;
	}
}

void DoubleLinkedList::remove(HashEntry data)
{

	bool isFound(false); 
	
	if(isEmpty())
	{
		std::cout << "list is empty" << std::endl;   
	}else{
		
		if(data.getKey() == LinkedList::getHead()->getValue().getKey()){
			
			LinkedNode * oldhead = LinkedList::getHead(); 
			LinkedNode * newhead = LinkedList::getHead()->getNextLinkedNode(); 
			
			LinkedList::setHead(newhead); 
			
			oldhead->setNextLinkedNode(nullptr);
			newhead->setPrevLinkedNode(nullptr);
			
			delete oldhead; 
			
			isFound = true; 
			
		}else if (data.getKey() == LinkedList::getTail()->getValue().getKey()){
			
			LinkedNode * oldtail = LinkedList::getTail();
			LinkedNode * newtail = LinkedList::getTail()->getPrevLinkedNode(); 
			
			LinkedList::setTail(newtail);
			
			oldtail->setPrevLinkedNode(nullptr); 
			newtail->setNextLinkedNode(nullptr); 
			
			delete oldtail; 
			
			isFound = true;
			
		}else{
			LinkedNode * currentnode = LinkedList::getHead(); 
			
			while(currentnode != nullptr && !isFound)
			{
				if(currentnode->getValue().getKey() == data.getKey())
				{
					LinkedNode * nextNode = currentnode->getNextLinkedNode(); 
					LinkedNode * prevNode = currentnode->getPrevLinkedNode(); 
					
					nextNode->setPrevLinkedNode(prevNode); 
					prevNode ->setNextLinkedNode(nextNode); 
					
					currentnode->setPrevLinkedNode(nullptr); 
					currentnode->setNextLinkedNode(nullptr);
					
					delete currentnode; 
					
					isFound = true; 
				}else{ 
					currentnode = currentnode->getNextLinkedNode(); 
				}
			}
			
			if(!isFound) 
			{
				std::cout << "Node does not exist in List" << std::endl;  
			}else
			{ 
				std::cout << "Element " << data.getKey() << " has been removed!" << std::endl; 
			}
		}
	}
}

int DoubleLinkedList::find(int key)
{ 
		if(isEmpty())
		{
			return -1; 
		}else{
			LinkedNode* currentnode = LinkedList::getHead(); 
			
			while(currentnode != nullptr)
			{
				if(key == currentnode->getValue().getKey())
				{
					return currentnode->getValue().getValue(); 
				}else{
					currentnode = currentnode->getNextLinkedNode(); 
				}
			}
			
			return -1; 
		}
}

void DoubleLinkedList::insertLinkedNode(LinkedNode * node, HashEntry data)
{
	LinkedNode * newNode = new LinkedNode(data, nullptr, nullptr);  
	
	if(!isEmpty())
	{
		LinkedNode * currentNode = node; 
		if(currentNode == LinkedList::getTail())
		{
			currentNode->setNextLinkedNode(newNode);
			newNode->setPrevLinkedNode(currentNode); 
			LinkedList::setTail(newNode); 
			
		}else if(currentNode == LinkedList::getHead()){
			newNode->setNextLinkedNode(currentNode);
			currentNode->setPrevLinkedNode(newNode); 
			LinkedList::setHead(newNode); 
		}else{
			currentNode->getNextLinkedNode()->setPrevLinkedNode(newNode); 
			newNode->setNextLinkedNode(currentNode->getNextLinkedNode()); 
			currentNode -> setNextLinkedNode(newNode); 
			newNode->setPrevLinkedNode(currentNode); 
			
		}
		
	}else{
		LinkedList::setHead(newNode);
		LinkedList::setTail(newNode);
	}
}

void DoubleLinkedList::insertAfterLinkedNode(LinkedNode * node, HashEntry data)
{
	LinkedNode * newNode = new LinkedNode(data, nullptr, nullptr);  
	
	if(!isEmpty())
	{
		LinkedNode * currentNode = node; 
		if(currentNode == LinkedList::getTail())
		{
			currentNode->setNextLinkedNode(newNode); 
			newNode->setPrevLinkedNode(currentNode); 
			LinkedList::setTail(newNode); 
		}else{
			newNode->setPrevLinkedNode(currentNode); 
			newNode->setNextLinkedNode(currentNode->getNextLinkedNode()); 
			currentNode->getNextLinkedNode()->setPrevLinkedNode(newNode); 
			currentNode->setNextLinkedNode(newNode); 
		}
	}else{
		LinkedList::setHead(newNode);
		LinkedList::setTail(newNode); 
	} 
}

void DoubleLinkedList::insertBeforeLinkedNode(LinkedNode * node, HashEntry data)
{
	LinkedNode * newNode = new LinkedNode(data, nullptr, nullptr);  
	
	if(!isEmpty())
	{
		LinkedNode * currentNode = node; 
		if(currentNode == LinkedList::getHead())
		{
			currentNode->setPrevLinkedNode(newNode); 
			newNode->setNextLinkedNode(currentNode); 
			LinkedList::setHead(newNode); 
		}else{
			newNode->setNextLinkedNode(currentNode); 
			newNode->setPrevLinkedNode(currentNode->getPrevLinkedNode()); 
			currentNode->getPrevLinkedNode()->setNextLinkedNode(newNode); 
			currentNode->setPrevLinkedNode(newNode); 
		}
	}else{
		LinkedList::setHead(newNode); 
		LinkedList::setTail(newNode);
	}
}