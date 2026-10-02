#include <iostream>
#include <fstream>
#include "DoubleLinkedList.h"
#include "HashEntry.h"
#include "HashTableArray.h" 
#include "HashTableCuckoo.h" 
#include "HashTableChaining.h"


// Honor Pledge:
//
// I pledge that I have neither given nor
// received any help on this assignment.
//
// rjmeyer

int main()
{
	std::cout << "Welcome to Blue IV's Can of Who Hash!" <<std::endl; 
	int input = 0; 
	
	while(input != 5)
	{
		std::cout << "1) Linear Probing \n"; 
		std::cout << "2) Quadratic Probing \n"; 
		std::cout << "3) Separate Chaining \n"; 
		std::cout << "4) Cuckoo Hashing \n";  
		std::cout << "5) Quit Program \n";

		std::cout << "\n Please enter your choice: "; 
		std::cin >> input; 
		
		int size = 0;
		if(input != 5)
		{
			std::cout << "\n Please enter the size of the Hash Table: "; 
			std::cin >> size; 
		}
		
		//check load factor against size incase there's a need to Rehash
		
		std::ifstream myFile("data.txt");
		
		if(input == 1)
		{	
			HashTableArray * table = new HashTableArray(size);
			table->setProbingType(true);
			
			if(myFile.is_open())
			{
				int key = 0; 
				int value = 0; 
				int elements = 0; 
				
				while(myFile >> key >> value)
				{
					elements++; 
					
					if((double)elements/table->getSize() >= 1.00)
					{
						table->setReHash(true); 
					}else{
						table->insert(key, value); 
					}
				}
			}
			
			myFile.close(); 
			
			if(table->getReHash())
			{
				std::cout << "<--- Insufficient Hash Table Size! Re-Hash --->" << std::endl;
				input = 4;
			}else{
				table->print();
			}
			
			 
			
			while(input != 4)
			{
				
				std::cout << "1) Search For Entry \n"; 
				std::cout << "2) Remove Entry \n"; 
				std::cout << "3) Print HashTable \n"; 
				std::cout << "4) Return to Main Menu \n"; 
				
				std::cout << "Please enter your choice: ";
				std::cin >> input; 
				
				if(input == 1)
				{
					int keySearch = 0; 
					
					std::cout << "\nSearch (please enter a Key): "; 
					std::cin >> keySearch; 
					
					if(table->search(keySearch) != -1)
					{
						std::cout << "\nKey: " << keySearch << " Value: " << table->search(keySearch) << std::endl;
					}else{
						std::cout << "\nInvalid Key! Key was not found in table!" << std::endl; 
					}
					
				}else if(input == 2){
					int keyRemove = 0; 
					
					std::cout << "\nRemove (please enter a Key): "; 
					std::cin >> keyRemove; 
					
					if(table->search(keyRemove) != -1)
					{
						table->remove(keyRemove);
						std::cout << "\nKey " << keyRemove << " removed" << std::endl;
					}else{
						std::cout << "\nInvalid Key! Key does not exist in table" << std::endl; 
					}
					 
				}else if(input == 3){
					table->print(); 
				}
				
				std::cout << std::endl; 
			}
			
			delete table; 
			
		}else if(input == 2){
			HashTableArray * table = new HashTableArray(size);
			
			if(myFile.is_open())
			{
				int key = 0; 
				int value = 0; 
				int elements = 0; 
				
				while(myFile >> key >> value)
				{
					elements++; 
					
					if((double)elements/table->getSize() >= 1.00)
					{
						table->setReHash(true); 
					}else{
						table->insert(key, value); 
					}
				}
			}
			
			myFile.close(); 
			
			if(table->getReHash())
			{
				std::cout << "<--- Insufficient Hash Table Size! Re-Hash --->" << std::endl;
				input = 4;
			}else{
				table->print();
			}
			
			while(input != 4)
			{ 
				
				std::cout << "1) Search For Entry \n"; 
				std::cout << "2) Remove Entry \n"; 
				std::cout << "3) Print HashTable \n"; 
				std::cout << "4) Return to Main Menu \n"; 
				
				std::cout << "Please enter your choice: ";
				std::cin >> input; 
				 
				if(input == 1)
				{
					int keySearch = 0; 
					
					std::cout << "\nSearch (please enter a Key): "; 
					std::cin >> keySearch; 
					
					if(table->search(keySearch) != -1)
					{
						std::cout << "\nKey: " << keySearch << " Value: " << table->search(keySearch) << std::endl;
					}else{
						std::cout << "\nInvalid Key! Key was not found in table!" << std::endl; 
					}
					
				}else if(input == 2){
					int keyRemove = 0; 
					
					std::cout << "\nRemove (please enter a Key): "; 
					std::cin >> keyRemove; 
					
					if(table->search(keyRemove) != -1)
					{
						table->remove(keyRemove);
						std::cout << "\nKey " << keyRemove << " removed" << std::endl;
					}else{
						std::cout << "\nInvalid Key! Key does not exist in table" << std::endl; 
					}
					 
				}else if(input == 3){
					table->print(); 
				}
				
				std::cout << std::endl;
			}
			
			delete table; 
			
		}else if(input == 3){
			HashTableChaining * table = new HashTableChaining(size);
			
			if(myFile.is_open())
			{
				int key = 0; 
				int value = 0; 
				int elements = 0; 
				
				while(myFile >> key >> value)
				{
					elements++; 
					
					if((double)elements/table->getSize() >= 1.00)
					{
						table->setReHash(true); 
					}else{
						table->insert(key, value); 
					}
				}
			}
			
			myFile.close(); 
			
			if(table->getReHash())
			{
				std::cout << "<--- Insufficient Hash Table Size! Re-Hash --->" << std::endl;
				input = 4;
			}else{
				table->print();
			}
			
			while(input != 4)
			{
				std::cout << "1) Search For Entry \n"; 
				std::cout << "2) Remove Entry \n"; 
				std::cout << "3) Print HashTable \n"; 
				std::cout << "4) Return to Main Menu \n"; 
				
				std::cout << "Please enter your choice: ";
				std::cin >> input; 
				
				if(input == 1)
				{
					int keySearch = 0; 
					
					std::cout << "\nSearch (please enter a Key): "; 
					std::cin >> keySearch; 
					
					if(table->search(keySearch) != -1)
					{
						std::cout << "\nKey: " << keySearch << " Value: " << table->search(keySearch) << std::endl;
					}else{
						std::cout << "\nInvalid Key! Key was not found in table!" << std::endl; 
					}
					
				}else if(input == 2){
					int keyRemove = 0; 
					
					std::cout << "\nRemove (please enter a Key): "; 
					std::cin >> keyRemove; 
					
					if(table->search(keyRemove) != -1)
					{
						table->remove(keyRemove);
						std::cout << "\nKey " << keyRemove << " removed" << std::endl;
					}else{
						std::cout << "\nInvalid Key! Key does not exist in table" << std::endl; 
					}
					 
				}else if(input == 3){
					table->print(); 
				}
				
				std::cout << std::endl;
			}
			
			delete table; 
			
		}else if(input == 4){
			HashTableCuckoo * table = new HashTableCuckoo(size);
			
			if(myFile.is_open())
			{
				int key = 0; 
				int value = 0; 
				int elements = 0; 
				
				while(myFile >> key >> value)
				{
					elements++; 
					
					if((double)elements/table->getSize() >= 1.00)
					{
						table->setReHash(true); 
					}else{
						table->insert(key, value); 
					}
				}
			}
			
			myFile.close(); 
			
			if(table->getReHash())
			{
				std::cout << "<--- Insufficient Hash Table Size! Re-Hash --->" << std::endl;
			}else{
				table->print();
				input = 0;
			}
			
			while(input != 4)
			{
				
				std::cout << "1) Search For Entry \n"; 
				std::cout << "2) Remove Entry \n"; 
				std::cout << "3) Print HashTable \n"; 
				std::cout << "4) Return to Main Menu \n"; 
				
				std::cout << "Please enter your choice: ";
				std::cin >> input; 
	
				if(input == 1)
				{
					int keySearch = 0; 
					
					std::cout << "\nSearch (please enter a Key): "; 
					std::cin >> keySearch; 
					
					if(table->search(keySearch) != -1)
					{
						std::cout << "\nKey: " << keySearch << " Value: " << table->search(keySearch) << std::endl;
					}else{
						std::cout << "\nInvalid Key! Key was not found in table!" << std::endl; 
					}
					
				}else if(input == 2){
					int keyRemove = 0; 
					
					std::cout << "\nRemove (please enter a Key): "; 
					std::cin >> keyRemove; 
					
					if(table->search(keyRemove) != -1)
					{
						table->remove(keyRemove);
						std::cout << "\nKey " << keyRemove << " removed" << std::endl;
					}else{
						std::cout << "\nInvalid Key! Key does not exist in table" << std::endl; 
					}
					 
				}else if(input == 3){
					table->print(); 
				}
				
				std::cout << std::endl;
			}
			
			delete table; 
			
		}
		
		
	}
	
	std::cout << "Thank you for using Blue IV's program - Goodbye!" << std::endl; 
	
	return 0; 
}; 