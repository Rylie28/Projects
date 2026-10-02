#include "Node.h"

// Honor Pledge:
//
// I pledge that I have neither given nor
// received any help on this assignment.
//
// rjmeyer

Node::Node(int data) : data_(data)
{

}

Node::~Node()
{

}

int Node::getValue() const
{
	return data_; 
}

void Node::setData(int data)
{
	data_ = data; 
}