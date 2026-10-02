#include "TreeNode.h"

// Honor Pledge:
//
// I pledge that I have neither given nor
// received any help on this assignment.
//
// rjmeyer

std::string TreeNode::COLOR[] = {"No Color", "RED", "BLACK"};

//constructors
TreeNode::TreeNode(int data) : Node(data), parent_(nullptr), leftChild_(nullptr), rightChild_(nullptr), colorVal_(0)
{

}

TreeNode::TreeNode(const TreeNode & node) : Node(node.getValue()), parent_(nullptr), leftChild_(nullptr), rightChild_(nullptr), colorVal_(0)
{	
	parent_ = node.parent_; 
	leftChild_ = node.leftChild_; 
	rightChild_ = node.rightChild_; 
}

//destructors
TreeNode::~TreeNode()
{
	//TODO
	if (leftChild_ != nullptr)
	{
		delete leftChild_; 
	}
	
	if(rightChild_ != nullptr)
	{ 
		delete rightChild_; 
	}
}

TreeNode * TreeNode::getParent()
{
	return parent_; 
}

TreeNode * TreeNode::getRightChild()
{
	return rightChild_; 
}

TreeNode * TreeNode::getLeftChild()
{
	return leftChild_; 
}

std::string TreeNode::getColor()
{
	return COLOR[colorVal_]; 
}

void TreeNode::setParent(TreeNode * node)
{
	parent_ = node; 
}

void TreeNode::setRightChild(TreeNode * node)
{
	rightChild_ = node; 
}

void TreeNode::setLeftChild(TreeNode * node)
{
	leftChild_ = node; 
}

void TreeNode::setColor(int colorVal)
{
	colorVal_ = colorVal; 
}