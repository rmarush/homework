using System.Reflection.PortableExecutable;
using System.Text;

namespace HW7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            ReadInfo(phoneBook);
            Console.WriteLine("Your dictionary");
            PrintDictionary(phoneBook);
            FindPhone(phoneBook);
            CheckPhones(phoneBook);
            PrintDictionary(phoneBook);
            WriteInfo(phoneBook);
        }
        static void ReadInfo(Dictionary<string, string> dictionary)
        {
            try
            {
                using (StreamReader sr = new StreamReader(@"D:\phones.txt", Encoding.UTF8))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(" - ");
                        dictionary.Add(parts[0], parts[1]);
                    }
                }
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("Unauthorized access: " + e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Directory not found: " + e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine("I/O error: " + e.Message);
            }
        }
        static void PrintDictionary(Dictionary<string, string> dictionary)
        {
            foreach (KeyValuePair<string, string> pair in dictionary)
            {
                Console.WriteLine($"{pair.Key} = {pair.Value}");
            }
        }

        static void FindPhone(Dictionary<string, string> dictionary)
        {
            Console.Write("Input name to find phone: ");
            string nameToFind = Console.ReadLine();
            foreach(KeyValuePair<string, string> pair in dictionary)
            {
                if(pair.Value == nameToFind)
                {
                    Console.WriteLine($"{pair.Value} has a {pair.Key} number!");
                    return;
                }
            }
            Console.WriteLine("There isn't phone with this name in dictionary!");
        }
        static void CheckPhones(Dictionary<string, string> dictionary)
        {
            foreach(string key in dictionary.Keys.ToList()) 
            {
               if(key.StartsWith("80"))
               {
                    string newKey = "+3" + key;
                    dictionary[newKey] = dictionary[key];
                    dictionary.Remove(key);
               }
            }
        }
        static void WriteInfo(Dictionary<string, string> dictionary)
        {
            try
            {
                using(StreamWriter sw = new StreamWriter(@"D:\New.txt"))
                {
                    foreach(KeyValuePair<string,string> pair in dictionary)
                    {
                        sw.WriteLine(pair.Key);
                    }
                }
                Console.WriteLine("Information was added to file!");
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("Unauthorized access: " + e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Directory not found: " + e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine("I/O error: " + e.Message);
            }
        }
    }
}

/*
 * In Main() method declare Dictionary PhoneBook for keeping pairs PersonName-PhoneNumber. 
 * 1) From file "phones.txt" read 9 pairs into PhoneBook. Write only PhoneNumbers into file "Phones.txt".
 * 2) Find and print phone number by the given name (name input from console)
 * 3) Change all phone numbers, which are in format 80######### into new format +380#########. 
 * The result write into file «New.txt» 
*/