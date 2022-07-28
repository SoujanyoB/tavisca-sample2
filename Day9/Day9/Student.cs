using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class Student
    {
        private int id, age;
        private string FirstName, LastName, Location;

        public Student(int age)
        {
            this.age = age;
        }

        public void SetFirstName(string FirstName)
        {
            this.FirstName = FirstName;
        }

        public void SetLastName(string LastName)
        {
            this.LastName = LastName;
        }

        public void SetID(int ID)
        {
            this.id = ID;
        }

        public void SetLocation(string Location)
        {
            this.Location = Location;
        }

        public void displayInformation()
        {
            if (FirstName == null || LastName == null || Location == null)
            {
                throw new Exception("Personal details not found! Please set name and location.");
            }

            if (id == 0)
            {
                throw new Exception("ID not found! Please get your id!");
            }

            Console.WriteLine($"Name: {this.FirstName} {this.LastName}\nID: {this.id}\nLocation: {this.Location}\nAge: {this.age}");
        }

        public int getAge()
        {
            return this.age;
        }


        public static bool operator >(Student a, Student b)
        {
            return a.getAge() > b.getAge();
        }

        public static bool operator <(Student a, Student b)
        {
            return a.getAge() < b.getAge();
        }


    }
}
