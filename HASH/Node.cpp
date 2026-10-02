#include "Node.h"

// Honor Pledge:
//
// I pledge that I have neither given nor
// received any help on this assignment.
//
// rjmeyer

Node::Node(HashEntry data) : data_(data)
{

}

Node::~Node()
{

}

HashEntry Node::getValue() const
{
	return data_; 
}