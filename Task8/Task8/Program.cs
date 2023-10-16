using Task8.Classes;

namespace Task8
{
    internal class Program
    {
        enum Workers { Staff = 1, Developer, Teacher, End}
        static void Main(string[] args)
        {
            List<Person> persons = CreateList();
            PrintList(persons);
            persons.Sort();
            using(StreamWriter sw = new StreamWriter(@"D:\persons.txt"))
            {
                sw.WriteLine("Sorted names");
                foreach(Person person in persons)
                {
                    sw.WriteLine(person.Name);
                }
            }
            Console.WriteLine("------------------------");
            PrintList(persons);
            Console.WriteLine("------------------------");
            FindName(persons);
            Console.WriteLine("------------------------");
            List<Staff> staffs = CreateStaffList(persons);
            staffs.Sort();
            foreach(Staff staff in staffs)
            {
                staff.PrintInfo();
            }
            
        }
        static public List<Staff> CreateStaffList(List<Person> persons)
        {
            List<Staff> staffs = new List<Staff>();
            foreach(Staff person in persons)
            {
                if(person.GetType() == typeof(Developer)|| person.GetType() == typeof(Teacher))
                {
                    staffs.Add(person);
                }
            }
            return staffs;
        }
        static public void FindName(List<Person> persons)
        {
            Console.Write("Input name for find: ");
            string name = Console.ReadLine();
            foreach (Person person in persons)
            {
                if(person.Name == name)
                {
                    Console.WriteLine("Info about this people: ");
                    person.PrintInfo();
                }
            }
        }
        static public void PrintList(List<Person> persons)
        {
            foreach (Person person in persons)
            {
                person.PrintInfo();
            }
        }
        static public List<Person> CreateList()
        {
            List<Person> persons = new List<Person>();
            Workers workers = new Workers();
            while (true)
            {
                Console.WriteLine("---MENU---\n" +
                    "1 - Add Staff\n" +
                    "2 - Add Developer\n" +
                    "3 - Add Teacher\n" +
                    "4 - End");
                Console.Write("Input a your choice: ");
                Enum.TryParse(Console.ReadLine(), out workers);
                if (workers == Workers.End) return persons;
                Console.Write("Input a fullname: ");
                string[] fullname = Console.ReadLine().Split(' ');
                Console.Write("Input a salary: ");
                int salary = Int32.Parse(Console.ReadLine());
                switch (workers)
                {
                    case Workers.Staff:
                        Staff staff = new Staff(fullname[0], fullname[1], salary);
                        persons.Add(staff);
                        break;
                    case Workers.Developer:
                        Console.Write("Input a language: ");
                        string language = Console.ReadLine();
                        Developer developer = new Developer(fullname[0], fullname[1], salary, language);
                        persons.Add(developer);
                        break;
                    case Workers.Teacher:
                        Console.Write("Input a subject: ");
                        string subject = Console.ReadLine();
                        Teacher teacher = new Teacher(fullname[0], fullname[1], salary, subject);
                        persons.Add(teacher);
                        break;
                }
            }
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