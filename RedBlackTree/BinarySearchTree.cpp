#include "BinarySearchTree.h"

// Honor Pledge:
//
// I pledge that I have neither given nor
// received any help on this assignment.
//
// rjmeyer

BinarySearchTree::BinarySearchTree() : root_(nullptr), height_(0)
{


}

BinarySearchTree::~BinarySearchTree()
{
	if(root_ != nullptr)
	{
		delete root_; 
	}
}

BinarySearchTree::BinarySearchTree(const BinarySearchTree & tree) : root_(nullptr), height_(0)
{
	//copy over the root and then recursion will do the rest
	root_ = copyTree(tree.root_); 
}

void BinarySearchTree::insert(int num)
{
	TreeNode * newNode = new TreeNode(num); 
	root_ = insertNode(root_, newNode);  
}

//root_
TreeNode * BinarySearchTree::getRoot()
{
	return root_; 
}

void BinarySearchTree::setRoot(TreeNode * root)
{
	root_ = root; 
}	

//height_
int BinarySearchTree::getHeight(TreeNode * node)
{
	int leftHeight(0), rightHeight(0), height(0); 
	
	if(node == nullptr)
	{
		return height; 
	}else{
		leftHeight = getHeight(node->getLeftChild()); 
		rightHeight = getHeight(node->getRightChild()); 
		
		if(leftHeight > rightHeight)
		{
			height = leftHeight; 
		}else{
			height = rightHeight; 
		}
		
		return height + 1; 
	}
}

void BinarySearchTree::print(TreeNode * root)
{
	if(root == nullptr)
	{
		
	}else{		
	//moving these statements around can get you the different traversal orders 
		print(root->getLeftChild()); 
		
		std::cout << root->getValue() << " "; 
		
		print(root->getRightChild()); 
	}
}

/*void BinarySearchTree::remove(int data)
{
	root_ = deleteNode(root_, data); 
}*/

//helper function for copy constructor
TreeNode * BinarySearchTree::copyTree(TreeNode * node)
{
	if(node == nullptr)
	{
		return nullptr; 
	}else{
		TreeNode * newNode = new TreeNode(node->getValue()); 
		newNode->setLeftChild(copyTree(node->getLeftChild())); 
		newNode->setRightChild(copyTree(node->getRightChild())); 
		return newNode; 
	}
}


TreeNode * BinarySearchTree::insertNode(TreeNode * root, TreeNode * node)
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

/*TreeNode * BinarySearchTree::deleteNode(TreeNode * root, int data)
{
	if(root == nullptr)
	{
		return nullptr; 
	}else{
		if(data < root->getValue())
		{
			//Left subtree deletion
			root->setLeftChild(deleteNode(root->getLeftChild(), data)); 
		}else if(data > root->getValue()){
			//right subtree deletion
			root->setRightChild(deleteNode(root->getRightChild(), data)); 
		}else{
			//root deletion
			if (root->getLeftChild() == nullptr && root->getRightChild() == nullptr)
			{
				delete root; 
				return nullptr; 
			}else if (root->getLeftChild() == nullptr){
				TreeNode * node = root->getRightChild(); 
				root->setValue(node->getValue()); 
				root-setleftChild(node->getleftChild())
				root-setRightChild(node->getRightChild())
				
				node->setleftChild(nullptr); 
				node->setRightChild(nullptr); 
				node->setParent(nullptr); 
				
				delete node;
				return root;
			}else if(root->getRightChild() == nullptr){
				TreeNode * node = root->getLeftChild(); 
				root->setValue(node->getValue()); 
				root-setleftChild(node->getleftChild())
				root-setRightChild(node->getRightChild())
				
				node->setleftChild(nullptr); 
				node->setRightChild(nullptr); 
				node->setParent(nullptr); 
				
				delete node;
				return root; 
			}else{
				TreeNode * node = root->getRightChild(); 
				while(node != nullptr && node->getLeftChild() != nullptr)
				{
					node = node->getLeftChild(); 
				}
				
				root->setValue(node->getValue()); 
				root->setRightChild(deleteNode(root->getRightChild(), node->getValue())); 
			}
			
		}
		
	}
	
	return root; 
}*/ 