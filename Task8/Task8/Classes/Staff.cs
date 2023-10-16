using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8.Classes
{
    class Staff : Person, IComparable<Staff>
    {
        private int salary;
        public int Salary { get { return salary; } set { salary = value; } }
        public Staff(string name, string surname, int salary) : base(name, surname)
        {
            this.salary = salary;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Staff => {Name} {Surname} has {salary}$");
        }
        int IComparable<Staff>.CompareTo(Staff other)
        {
            return this.salary.CompareTo(other.salary);
        }
    }
}

/*
 * 1. Add two classes Persons and Staff (use the presentation code)
 * 2. Create two classes Teacher and Developer, derived from Staff. 
 * Add field subject for class Teacher; 
 * Add field level for class Developer; 
 * override method Print for both classes.
 * 3. In Main, specify a list of Person type and add objects of each type to it. Call for each item in the list method Print ().
 * 4. Enter the person's name. If this name present in  list - print information about this person
 * 5. Sort list by name, output to file
 * 6*. Create a list of Employees and move only workers(teachers+developers) there. Sort them by salary.
 */

