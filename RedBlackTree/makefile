Tree.exe: Node.o TreeNode.o BinarySearchTree.o RedBlackTree.o driver.o  
	g++ Node.o TreeNode.o BinarySearchTree.o RedBlackTree.o driver.o -o Tree.exe
	
Node.o: Node.cpp
	g++ -c Node.cpp -o Node.o
	
TreeNode.o: TreeNode.cpp
	g++ -c TreeNode.cpp -o TreeNode.o
	
BinarySearchTree.o: BinarySearchTree.cpp
	g++ -c BinarySearchTree.cpp -o BinarySearchTree.o
	
RedBlackTree.o: RedBlackTree.cpp
	g++ -c RedBlackTree.cpp -o RedBlackTree.o
	
driver.o: driver.cpp
	g++ -c driver.cpp -o driver.o
	
clean:
	rm -rf *.o Tree.exe
	
run: 
	Tree.exe