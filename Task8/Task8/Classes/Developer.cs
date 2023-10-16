using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8.Classes
{
    class Developer : Staff
    {
        private string language;
        public string Language { get { return language; } set {  language = value; } }
        public Developer(string name, string surname, int salary, string language) : base(name, surname, salary)
        {
            this.language = language;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Developer => {Name} {Surname} knows {language} and have {Salary}$");
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
