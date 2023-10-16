using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFiles.Classes
{
    internal class PhoneBook
    {
        private Dictionary<string, string> data;
        private FileHandler fileHandler;
        public Dictionary<string, string> Data { get { return data; } }
        public FileHandler FileHandler { get { return fileHandler; } }
        public PhoneBook()
        {
            this.data = new Dictionary<string, string>();
            this.fileHandler = new FileHandler();
        }
        public void CheckPhoneBook()
        {
            foreach (KeyValuePair<string, string> pair in data)
            {
                Console.WriteLine($"Number: {pair.Key} == {pair.Value}");
            }
        }
        public void AddPhone()
        {
            try
            {
                Console.Write("Input a phone number(start with +380): ");
                string phone = Console.ReadLine();
                if (!phone.StartsWith("+380")) throw new ApplicationException("Number should start with +380!");
                if (phone.Length != 13) throw new LenghtException("Number must have 12 characters!");
                Console.Write("Input a name: ");
                string name = Console.ReadLine();
                data.TryAdd(phone, name);
                fileHandler.WriteToFile(this);
                Console.WriteLine("Number was added!");
            }
            catch (LenghtException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ApplicationException e)
            {
                Console.WriteLine(e.Message);
            }
        }
       
        public void DeletePhone()
        {
            KeyValuePair<string, string> pair = FindPhone();
            if (pair.Key == null) return;
            data.Remove(pair.Key);
            fileHandler.WriteToFile(this);
            Console.WriteLine("Phone was deleted!");
        }
        public void EditPhone()
        {
            try
            {
                KeyValuePair<string, string> pair = FindPhone();
                if (pair.Key == null) return;
                Console.WriteLine("Input new phone to edit: ");
                string newPhone = Console.ReadLine();
                if (!newPhone.StartsWith("+380")) throw new ApplicationException("Number should start with +380!");
                if (newPhone.Length != 13) throw new LenghtException("Number must have 12 characters!");
                data[newPhone] = data[pair.Key];
                data.Remove(pair.Key);
                fileHandler.WriteToFile(this);
                Console.WriteLine("Number was edited!");
                return;
            }
            catch (LenghtException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ApplicationException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public KeyValuePair<string, string> FindPhone()
        {
            try
            {
                Console.WriteLine("Input a name: ");
                string name = Console.ReadLine();
                foreach (KeyValuePair<string, string> pair in data)
                {
                    if (pair.Value == name)
                    {
                        Console.WriteLine($"{pair.Key} - {pair.Value}");
                        return pair;
                    }
                }
                throw new KeyNotFoundException($"Name '{name}' not found in the dictionary.");
            }
            catch (KeyNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            return default(KeyValuePair<string, string>);
        }
    }
}
