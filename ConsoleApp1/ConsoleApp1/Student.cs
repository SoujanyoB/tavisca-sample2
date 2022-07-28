using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        public int RollNo { get; set; }
        public int Age;
        public int ClassIn { get; set; }
        
        public string FirstName { get; set; } 
        public string LastName { get; set; }

        public Student() { }

        public void getXYZ()
        {

        }

        public void showName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }

        public Student(int rollNo, int age, int classIn, string firstName, string lastName)
        {
            RollNo = rollNo;
            Age = age;
            ClassIn = classIn;
            FirstName = firstName;
            LastName = lastName;
        }

        public void displayInfo()
        {
            Console.WriteLine("Name: {0} {1}\nRoll No: {2}\nClass: {3}\nAge: {4}", FirstName, LastName, RollNo, ClassIn, Age);
        }

    }
}
