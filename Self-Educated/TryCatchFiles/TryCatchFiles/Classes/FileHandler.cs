using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFiles.Classes
{
    internal class FileHandler
    {
        private string path = @"D:\phones.txt";
        public string Path { get { return path; } }
        public void ReadFromFile(PhoneBook phoneBook)
        {
            try
            {
                using (StreamReader sr = new StreamReader(Path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(" - ");
                        phoneBook.Data.TryAdd(parts[0], parts[1]);
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
        public void WriteToFile(PhoneBook phoneBook)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(Path))
                {
                    foreach (KeyValuePair<string, string> pair in phoneBook.Data)
                    {
                        sw.WriteLine($"{pair.Key} - {pair.Value}");
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
    }
}
