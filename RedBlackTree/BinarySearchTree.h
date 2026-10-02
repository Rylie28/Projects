#ifndef BINARYSEARCHTREE_H
#define BINARYSEARCHTREE_H

// Honor Pledge:
//
// I pledge that I have neither given nor
// received any help on this assignment.
//
// rjmeyer

#include "TreeNode.h"
#include <iostream>

class BinarySearchTree
{

	public: 
		BinarySearchTree(); 
		virtual ~BinarySearchTree();  
		BinarySearchTree(const BinarySearchTree & tree); 

		virtual void insert(int num); 

		TreeNode * getRoot(); 
		void setRoot(TreeNode * root); 
		int getHeight(TreeNode * node); 
		void print(TreeNode * root); 
		//void remove(int data); 
	private: 
		//helper function for copy constructor
		TreeNode* copyTree(TreeNode* node); 
		TreeNode * insertNode(TreeNode * root, TreeNode * node); 
		//TreeNode * deleteNode(TreeNode * root, int data); 
		//int height(TreeNode * root); 
		TreeNode * root_; 
		int height_; 

};
#endif