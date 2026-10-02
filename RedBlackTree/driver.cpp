#include <iostream>
#include <fstream>
#include "RedBlackTree.h"

// Honor Pledge:
//
// I pledge that I have neither given nor
// received any help on this assignment.
//
// rjmeyer

int main()
{
	RedBlackTree * tree = new RedBlackTree();  
	 
	//phase 2
	std::ifstream infile; 
	infile.open("data.txt"); 
	
	int data = 0;
	
	while(infile >> data)
	{
		tree->insert(data); 
	}
	
	tree->print(tree->getRoot());
	std::cout << std::endl;
	std::cout << "Root: " << tree->getRoot()->getValue() << std::endl;
	std::cout << "Color: " << tree->getRoot()->getColor() << std::endl; 
	std::cout << "Red Nodes: ";
	tree->printRedNodes(tree->getRoot()); 
	std::cout<<std::endl; 
	std::cout << "Black Nodes: ";
	tree->printBlackNodes(tree->getRoot()); 
	std::cout<<std::endl; 
	
	
	infile.close(); 
	
	delete tree;
	
	return 0; 
};