#include <fstream>
#include <iostream>
#include <string>
#include <array>
#include "Student.h"
// Honor Pledge:
//
// I pledge that I have neither given nor
// received any help on this assignment.
//
// rjmeyer

//sorting method 
void bubbleSortArray(Student arr[], int n)
{
	for(int k=0; k<n; k++)
    {
        for(int j=k+1; j<n; j++) 
        { 
            if(arr[k].getGPA() < arr[j].getGPA())
            {
                Student temp = arr[k]; 
                arr[k]=arr[j]; 
				arr[j]=temp; 
            }
        }
    }
}
//(int)gradePoints

int main ()
{
	std::cout << "***		GPA Calculation Program			***" << std::endl;
	
	//variables that the file lines get read into
	std::string name;
	int grade; 
	int hours; 
	
	//variables for the arrays
	int max = 30; 
	int i = 0; 
	
	//array of student objects 
    Student student_array[max];
	
	//reading the file into the student object array 
	std::ifstream inputFile("students.txt");
	if (inputFile.is_open())
	{
		while (inputFile >> name >> grade >> hours)
		{
			Student student(name, grade, hours); 
		    student_ar
			ray[i] = student;  
		    i++; 
		}
		inputFile.close();
	}
	else
	{
		std::cout << "Unable to open file" << std::endl;
	}
	
	//sort array via bubble sort
	bubbleSortArray(student_array, max); 
	
	
	//print out student array via loop
	for (int a = 0; a < i; a++)
    {
       student_array[a].printInfo(); 
    }
	
	std::cout << "***		Goodbye!		***" << std::endl;
	return 0;
};
