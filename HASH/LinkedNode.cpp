#include "LinkedNode.h"

// Honor Pledge:
//
// I pledge that I have neither given nor
// received any help on this assignment.
//
// rjmeyer

//constructors
LinkedNode::LinkedNode(HashEntry data) : Node(data), nextLinkedNode_(nullptr), prevLinkedNode_(nullptr)
{

}

LinkedNode::LinkedNode(const LinkedNode & node) : Node(node.getValue()), nextLinkedNode_(nullptr), prevLinkedNode_(nullptr)
{	
	nextLinkedNode_ = node.nextLinkedNode_; 
	prevLinkedNode_ = node.prevLinkedNode_; 
}

LinkedNode::LinkedNode(HashEntry data, LinkedNode * nextLinkedNode, LinkedNode *prevLinkedNode) : Node(data), nextLinkedNode_(nextLinkedNode), prevLinkedNode_(prevLinkedNode)
{
	
}

//destructors
LinkedNode::~LinkedNode()
{
	if(hasNextLinkedNode())
	{
		delete nextLinkedNode_; 
		//std::cout << "Linked Node destructor called" << std::endl; 
	}
}

//accessor methods for nextLinkedNode_
LinkedNode * LinkedNode::getNextLinkedNode()
{
	if(hasNextLinkedNode())
	{
		return nextLinkedNode_; 
	}
	
	return nullptr; 
}

void LinkedNode::setNextLinkedNode(LinkedNode * node)
{
	nextLinkedNode_ = node; 
}

bool LinkedNode::hasNextLinkedNode()
{
	if(nextLinkedNode_ == nullptr)
	{
		return false; 
	}
	
	return true; 
}

//accessor methods for prevLinkedNode_
LinkedNode * LinkedNode::getPrevLinkedNode()
{
	if(hasPrevLinkedNode())
	{
		return prevLinkedNode_; 
	}
	
	return nullptr; 
}

void LinkedNode::setPrevLinkedNode(LinkedNode * prevLinkedNode)
{
	prevLinkedNode_ = prevLinkedNode; 
}

bool LinkedNode::hasPrevLinkedNode()
{
	if(prevLinkedNode_ == nullptr)
	{
		return false; 
	}
	
	return true; 
}