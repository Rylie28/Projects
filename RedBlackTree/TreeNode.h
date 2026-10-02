#ifndef TREENODE_H
#define TREENODE_H

// Honor Pledge:
//
// I pledge that I have neither given nor
// received any help on this assignment.
//
// rjmeyer

#include "Node.h"
#include <iostream> 

class TreeNode : public Node
{
	public: 
		TreeNode(int data = -1); 
		TreeNode(const TreeNode & node);
		virtual ~TreeNode(); 
		
		TreeNode * getParent();
		TreeNode * getRightChild(); 
		TreeNode * getLeftChild();  
		std::string getColor(); 

		void setParent(TreeNode * node); 	
		void setRightChild(TreeNode * node); 
		void setLeftChild(TreeNode * node); 
		void setColor(int colorVal); 
	private: 
		TreeNode * leftChild_; 
		TreeNode * rightChild_; 
		TreeNode * parent_; 
		
		//keep track of the nodes color
		int colorVal_;		// Index of the Color array
		static std::string COLOR[3];

};
#endif