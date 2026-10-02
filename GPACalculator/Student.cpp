#include "Student.h"
// Honor Pledge:
//
// I pledge that I have neither given nor
// received any help on this assignment.
//
// rjmeyer


//constructor with parameters 
Student::Student(std::string id, int gradePoints, int creditHours)
{
	id_ = id; 
	gradePoints_ = gradePoints; 
	creditHours_ = creditHours; 
	gpa_ = 0; 
	letterGrade_ = 'F'; 
}
//basic empty constructor 
Student::Student()
{
    id_ = ""; 
	gradePoints_ = 0; 
	creditHours_ = 0;
}

//destructor
Student::~Student()
{
}
//print function
void Student::printInfo()
{
	std:: cout << getID() << ": " << std::fixed << std::setprecision(2) << getGPA() << "		" << getLetterGrade() << std::endl;
}

//accessor functions
std::string Student::getID()
{
	return id_; 
}

int Student::getCreditHours()
{
	return creditHours_; 
}

int Student::getGradePoints()
{
	return gradePoints_; 
}

//return letter grade based on GPA
char Student::getLetterGrade()
{
	if(gpa_ >= 3.70)
	{
		letterGrade_ = 'A';
	}else if(gpa_ >= 2.70) 
	{
		letterGrade_ = 'B';
	}else if(gpa_ >= 1.70) 
	{
		letterGrade_ = 'C';
	}else if(gpa_ >= 0.70)
	{
		letterGrade_ = 'D';
	}
	
	return letterGrade_; 
}

//divide the grade points by credit hours to figure out current GPA
double Student::getGPA()
{
	gpa_ = (double)gradePoints_/creditHours_; 
	return gpa_;
}
