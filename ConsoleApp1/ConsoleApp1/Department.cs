using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Department
    {
        public string? DeptName, DeptLocation;

        public Department() { }

        public Department(string DeptName, string DeptLocation)
        {
            this.DeptName = DeptName;
            this.DeptLocation = DeptLocation;
        }

        public void GetDeptName(string deptName)
        {
            DeptName = deptName;
        }

        public void GetDeptLocation(string deptLoc)
        {
            DeptLocation = deptLoc;
        }
    }

    internal class Employeee : Department
    {
        public string? FirstName, LastName;

        public Employeee() { }

        public Employeee(string firstName, string lastName, string deptName, string deptLoc) : base(deptName, deptLoc)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void GetFirstName(string firstName)
        {
            FirstName = firstName;
        }

        public void GetLastName(string lastName)
        {
            LastName = lastName;
        }

        public void GetDeptDetails()
        {
            Console.WriteLine("Department Name: {0}\nDepartment Location: {1}", DeptName, DeptLocation);
        }
    }
}
