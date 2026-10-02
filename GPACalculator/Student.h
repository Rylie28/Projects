#include <iostream>
#include <iomanip> 
#include <string>
// Honor Pledge:
//
// I pledge that I have neither given nor
// received any help on this assignment.
//
// rjmeyer


class Student
{
	public:
		Student(std::string, int, int); //constructor
		Student(); //empty constructor
		~Student(); //destructor 
		//print method
		void printInfo(); 
		//accessor methods
		std::string getID(); 
		int getGradePoints(); 
		int getCreditHours(); 
		char getLetterGrade(); 
		double getGPA();
	private: 
		std::string id_; 
		int gradePoints_, creditHours_; 
		double gpa_; 
		char letterGrade_; 
};
