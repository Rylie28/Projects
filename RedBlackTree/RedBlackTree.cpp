#include "RedBlackTree.h"

// Honor Pledge:
//
// I pledge that I have neither given nor
// received any help on this assignment.
//
// rjmeyer

RedBlackTree::RedBlackTree() : BinarySearchTree()
{
	
}
RedBlackTree::~RedBlackTree()
{
	
}
		
void RedBlackTree::insert(int data) 
{
	TreeNode * newNode = new TreeNode(data); 
	newNode->setColor(1); 
	BinarySearchTree::setRoot(insertNode(BinarySearchTree::getRoot(), newNode)); 
	//balancing color 
	TreeNode * root = BinarySearchTree::getRoot(); 
	balanceColor(root, newNode);  
}


void RedBlackTree::printRedNodes(TreeNode * root)
{
	if(root == nullptr)
	{

	}else if(root->getColor() == "BLACK"){ 
	
		printRedNodes(root->getLeftChild()); 
		printRedNodes(root->getRightChild()); 
		
	}else{		
	//moving these statements around can get you the different traversal orders 
	
		printRedNodes(root->getLeftChild()); 
			
		std::cout << root->getValue() << " ";  
			
		printRedNodes(root->getRightChild()); 
	}
}
		
void RedBlackTree::printBlackNodes(TreeNode * root)
{
	if(root == nullptr)
	{
		
	}else if(root->getColor() == "RED"){ 
		printBlackNodes(root->getLeftChild()); 
		printBlackNodes(root->getRightChild()); 
	
	}else{		
	//moving these statements around can get you the different traversal orders 
		std::cout << root->getValue() << " "; 
		
		printBlackNodes(root->getLeftChild()); 
		
		printBlackNodes(root->getRightChild()); 
	}
}

TreeNode * RedBlackTree::insertNode(TreeNode * root, TreeNode * node)
{
	if(root == nullptr)
	{ 
		return node; 
	}else{
		if(node->getValue() < root->getValue())
		{
			//left subtree
			root->setLeftChild(insertNode(root->getLeftChild(), node)); 
			root->getLeftChild()->setParent(root); 
			
		}else if (node->getValue() >= root->getValue()){
			//right subtree
			root->setRightChild(insertNode(root->getRightChild(), node)); 
			root->getRightChild()->setParent(root); 
		}
		
		return root; 
	}
}

//Rotation methods to rotate left and right, newNode is the node being rotated
void RedBlackTree::rotateLeft(TreeNode *& root, TreeNode *& newNode) // root = root of the tree
{ 
	TreeNode* parent = newNode->getParent();
    parent->setRightChild(newNode->getLeftChild());
	
    if (parent->getRightChild() != nullptr)
	{
        newNode->getLefttChild()->setParent(parent);
	}
	
    newNode->setParent(parent->getParent());
	
    if (parent == root)
	{
        BinarySearchTree::setRoot(newNode);
	}else if(parent == parent->getParent()->getLeftChild()){
		
        parent->getParent()->setLeftChild(newNode);
	}else{
		
        parent->getParent()->setRightChild(newNode);
	}
    newNode->setLeftChild(parent);
    parent->setParent(newNode);
}

void RedBlackTree::rotateRight(TreeNode *& root, TreeNode *& newNode)
{
	TreeNode* parent = newNode->getParent();
    parent->setLeftChild(newNode->getRightChild());
	
    if (newNode->getLeftChild() != nullptr)
	{
        newNode->getLeftChild()->setParent(parent);
	}
	
    newNode->setParent(parent->getParent());
	
    if (parent == root)
	{
        BinarySearchTree::setRoot(newNode);
	}else if(parent == parent->getParent()->getLeftChild()){
		
        parent->getParent()->setLeftChild(newNode);
	}else{
		
        parent->getParent()->setRightChild(newNode);
	}
    newNode->setRightChild(parent);
    parent->setParent(newNode);
}
			
void RedBlackTree::balanceColor(TreeNode *& root, TreeNode *& newNode)
{
	TreeNode * parent = nullptr;
	TreeNode * grandparent = nullptr; 
	
	while(newNode != root && newNode->getColor() == "RED" && newNode->getParent()->getColor() == "RED")
	{
		//always reset the parent and grandparent nodes  
		parent = newNode->getParent();  
		grandparent = parent->getParent(); 
		
		//find which side the uncle is on and what subtree we're working in
		if(parent == grandparent->getLeftChild()) // in the left subtree
		{
			TreeNode * uncle = grandparent->getRightChild();
			
			//Uncle is red and exists
			if(uncle != nullptr && uncle->getColor() == "RED")
			{
				grandparent->setColor(1); 
				parent->setColor(2); 
				uncle->setColor(2);
				
				//set grandparent to red so need to check that it's okay
				newNode = grandparent; 
			}else{
				//rotations in the left subtree
				if(newNode == parent->getRightChild()) //double rotations
				{
					//rotate 
					rotateLeft(root, newNode); 
				
					//reassign
					newNode = parent; 
					parent = newNode->getParent();
				}
				//rotate 
				rotateRight(root, parent); 
				//recolor 
				parent->setColor(2);
				grandparent->setColor(1); 
				//check the parent
				newNode = parent; 
			}
		}else{ //in the right subtree
			TreeNode * uncle = grandparent->getLeftChild(); 
			
			//uncle is red and exists
			if(uncle != nullptr && uncle->getColor() == "RED")
			{
				grandparent->setColor(1); 
				parent->setColor(2); 
				uncle->setColor(2); 
				
				//check the grandparent
				newNode = grandparent; 
			}else{
				//rotations in the Right subtree
				if(newNode == parent->getLeftChild()) //double rotations
				{
					rotateRight(root, newNode); 
					
					//reassign
					newNode = parent; 
					parent = newNode->getParent(); 
				}
				//rotate 
				rotateLeft(root, parent); 
				
				//recolor 
				parent->setColor(2); 
				grandparent->setColor(1); 
				
				//check the parent 
				newNode = parent; 
			}
		
		}
	}
	
	BinarySearchTree::getRoot()->setColor(2); 
	
}