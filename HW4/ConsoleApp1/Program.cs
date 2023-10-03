using ConsoleApp1.Class;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] person = CreateArray();
            PrintInfo(person);
            Console.Write("Input the age you would consider very young: ");
            CheckAge(person, Int32.Parse(Console.ReadLine()));
            PrintInfo(person);
            Console.Write("Plese, input the name which you want to find: ");
            FindSameName(person, Console.ReadLine());
        }
        public static void PrintInfo(Person[] person)
        {
            Console.WriteLine("Information about all persons: ");
            foreach (Person pers in person)
            {
                Console.WriteLine(pers);
            }
        }
        public static Person[] CreateArray()
        {
            Person[] person = new Person[6];
            Person tempPers = new Person();
            for (int i = 0; i < person.Length; i++)
            {
                Console.WriteLine($"Information about Person №{i + 1}:");
                person[i] = tempPers.Input();
            }
            return person;
        } 
        public static void CheckAge(Person[] person, int checkedAge)
        {
            for (int i = 0; i < person.Length; i++)
            {
                if (person[i].Age() < checkedAge) person[i].ChangeName("Very Young");
            }
        }
        public static void FindSameName(Person[] person, string findName)
        {
            for (int i = 0; i < person.Length; i++)
            {
                for (int j = i + 1; j < person.Length; j++)
                {
                    if (person[i] == person[j]) Console.WriteLine($"{person[i]} and {person[j]} have the same name");
                }
            }
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