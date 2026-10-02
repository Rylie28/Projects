#ifndef REDBLACKTREE_H
#define REDBLACKTREE_H

// Honor Pledge:
//
// I pledge that I have neither given nor
// received any help on this assignment.
//
// rjmeyer

#include "TreeNode.h"
#include "BinarySearchTree.h"

class RedBlackTree : public BinarySearchTree
{
	public: 
		RedBlackTree(); 
		virtual ~RedBlackTree(); 
		
		virtual void insert(int data); 
		
		//print methods
		/*You will need to use an Inorder Traversal in this method to 
		search for Red colored TreeNodes.*/
		void printRedNodes(TreeNode * root);
		
		/*You will need to use a Preorder Traversal in this method to 
		search for Black colored TreeNodes.*/
		void printBlackNodes(TreeNode * root);
		
	private:
		TreeNode* insertNode(TreeNode* root, TreeNode* node);
		void rotateLeft(TreeNode *& root, TreeNode *& newNode);
			/*This allows us to perform a left rotational shift of our tree to ensure proper
			balance is maintained. It will be called internally from our balanceColor
			method.*/ 
		void rotateRight(TreeNode *& root, TreeNode *& newNode);
			/*This allows us to perform a right rotational shift of our tree to ensure proper
			balance is maintained. It will be called internally from our balanceColor
			method.*/
		void balanceColor(TreeNode *& root, TreeNode *& newNode);
			/*This method allows us to maintain proper balance within our tree and properly
			adjusts the color of each node, if necessary, to adhere to the rules of a Red-Black
			Tree. This will be a large and complex function*/
}; 
#endif