using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Class
{
    internal class Person
    {
        private string name;
        private DateTime birthYear;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public DateTime BirthYear
        {
            set { birthYear = value; }
            get { return birthYear; }
        }
        public Person() { }
        public Person(string name, DateTime birthYear)
        {
            this.name = name;
            this.birthYear = birthYear; 
        }
        public int Age()
        {
            int age = DateTime.Now.Year - birthYear.Year;
            age = DateTime.Now.Month < birthYear.Month || (DateTime.Now.Month == birthYear.Month && DateTime.Now.Day <  birthYear.Day ) ? --age : age;
            return age;
        }
        public Person Input()
        {
            Console.Write("Input a name: ");
            string name = Console.ReadLine();
            Console.Write("Input a birthYear(format yyyy-mm-dd): ");
            while(true)
            {
                string dateInput = Console.ReadLine();
                if (DateTime.TryParse(dateInput, out DateTime birthDate))
                {
                    Person person = new Person(name, birthDate);
                    return person;
                }
                else
                {
                    Console.WriteLine("Uncorrect input, try again!");
                }
            }
        }
        public void ChangeName(string name) 
        {
            this.name = name;
        }
        public void Output()
        {
            Console.WriteLine(this.ToString());
        }
        public override string ToString()
        {
            return string.Format($"Name => {name} || Age => {Age()}");
        }
        public static bool operator ==(Person person1, Person person2)
        {
            return person1.name == person2.name;
        }
        public static bool operator !=(Person person1, Person person2)
        {
            return !(person1 == person2);
        }
    }
}
/*Define class Person. Class Person should consist of:
              a) two private fields: name and birthYear (the birthday year).
		(As a type for this field you may use DataTime type.)
              b) two properties for access to these fields (can use only get)
              c) default constructor and constructor with 2 parameters 
              d) methods: - Age() - to calculate the age of person
                   	  - Input() - to enter data about person from console
                  	  - ChangeName() - to change the name of person
                 	  - ToString() 
                   	  - Output() - to output information about person (call ToString())
                 	  - operator== (equal by name)
In the method Main() create 6 objects of Person type and enter information about them. 
Then calculate and output on the console name and Age of each person; 
Change the name of persons, which Age is less then 16, to "Very Young".
Output information about all persons on the console. 
Find and output information about Persons with the same names (use ==).	
*/