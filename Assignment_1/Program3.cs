using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    using CollegeStudent = College.StudentInfo.Student;
    using SchoolStudent = School.StudentInfo.Student;

    namespace College.StudentInfo
    {
        class Student
        {
            public void ShowDetails()
            {
                Console.WriteLine("This is College.StudentInfo.Student");
            }
        }
    }

    namespace School.StudentInfo
    {
        class Student
        {
            public void ShowDetails()
            {
                Console.WriteLine("This is School.StudentInfo.Student");
            }
        }
    }

    public class Program3
    {
        static void Main()
        {
            CollegeStudent collegeStudent = new CollegeStudent();
            SchoolStudent schoolStudent = new SchoolStudent();

            collegeStudent.ShowDetails();
            schoolStudent.ShowDetails();
        }
    }
}
