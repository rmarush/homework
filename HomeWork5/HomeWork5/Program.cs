using HomeWork5.Classes;
using System.Drawing;

namespace HomeWork5
{
    internal class Program
    {
        enum Jobs { Programmer = 1, Builder, End }
        static void Main(string[] args)
        {
            TaskOne();
            TaskTwo();
        }
        public static void TaskOne()
        {
            List<IDeveloper> people = CreateList();
            Console.WriteLine("Started list: ");
            PrintList(people);
            people.Sort();
            Console.WriteLine("\nSorted list: ");
            PrintList(people);
        }
        public static List<IDeveloper> CreateList()
        {
            List<IDeveloper> people = new List<IDeveloper>();
            while (true)
            {
                Jobs jobs = new Jobs();
                Console.WriteLine("What you want to create [Programmer/Builder]: ");
                Console.WriteLine("----CHOICE----" +
                "\n1 - Add Programmer" +
                "\n2 - Add Builder" +
                "\n3 - End input");
                Enum.TryParse(Console.ReadLine(), out jobs);
                switch (jobs)
                {
                    case Jobs.Programmer:
                        Console.Write("Input a language for your programmer: ");
                        string language = Console.ReadLine();
                        people.Add(new Programmer(language));
                        break;
                    case Jobs.Builder:
                        Console.Write("Input a tool for your builder: ");
                        string tool = Console.ReadLine();
                        people.Add(new Builder(tool));
                        break;
                    case Jobs.End:
                        Console.WriteLine("Input is end");
                        Console.Clear();
                        return people;
                    default:
                        Console.WriteLine("Input error, try again!");
                        break;
                }
                Console.Clear();
            }
        }
        public static void PrintList(List<IDeveloper> people)
        {
            foreach (IDeveloper human in people)
            {
                human.Destroy();
                human.Create();
            }
        }
        public static void TaskTwo()
        {
            Dictionary<uint, string> dictionary = new Dictionary<uint, string>();
            Console.Write("How much people you want to add? ");
            int count = Int32.Parse(Console.ReadLine());
            for(int i = 0; i < count; i++)
            {
                Console.Write("Input a ID: ");
                uint id = uint.Parse(Console.ReadLine());
                Console.Write("Input a name: ");
                string name = Console.ReadLine();
                dictionary.Add(id, name);
                Console.WriteLine($"№{i+1} has key => {id} and name => {name}");
            }
            Console.Clear();
            Console.Write("Input ID to find: ");
            uint idToFind = uint.Parse(Console.ReadLine());
            uint flag = 0;
            foreach(KeyValuePair<uint, string> kvp in dictionary)
            {
                if (kvp.Key == idToFind)
                {
                    Console.WriteLine($"People with ID = {kvp.Key} has name = {kvp.Value}");
                    flag = 1;
                    break;
                }
            }
            if(flag == 0)
            {
                Console.WriteLine($"There aren't people with ID = {idToFind} in your dictionary");
            }
        }
    }
}

/*
Create interface IDeveloper with property Tool, methods Create() and Destroy()
Create two classes Programmer (with field language) and Builder (with field tool), which implement this interface.
Create array or list of IDeveloper.Add some Programmers and Builders to it. Call Create() and Destroy() methods for all of it
Implement interface IComparable for clases and sort array or list of IDeveloper 

Create Console Application project in VS. In the Main() method declare Dictionary<uint,string>. 
Add to Dictionary from Console 7 pairs (ID, Name) of some persons. 
Ask user to enter ID, then find and write corresponding Name from your Dictionary. If you can't find this ID - say about it to user. 
 */