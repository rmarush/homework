using System.Collections;
using System.Collections.Generic;
using TryCatchFiles.Classes;
using TryCatchFiles.Enums;

namespace TryCatchFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook();
            phoneBook.FileHandler.ReadFromFile(phoneBook);
            do
            {
                Menu menu = new Menu();
                Console.WriteLine("--------MENU--------" +
                    "\n1 - Check PhoneBook" +
                    "\n2 - Add Phone" +
                    "\n3 - Delete Phone" +
                    "\n4 - Edit Phone" +
                    "\n5 - Find Phone" +
                    "\n6 - End program");
                Console.Write("Input a choice: ");
                try
                {
                    Enum.TryParse(Console.ReadLine(), out menu);
                    Console.WriteLine("--------------------");
                    if ((int)menu < 1 || (int)menu > 6) throw new ApplicationException("Input error, try again!");
                    switch (menu)
                    {
                        case Menu.CheckPhones:
                            phoneBook.CheckPhoneBook();
                            Console.WriteLine("Press a button to clear a console: ");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case Menu.AddPhone:
                            phoneBook.AddPhone();
                            Console.WriteLine("Press a button to clear a console: ");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case Menu.DeletePhone:
                            phoneBook.DeletePhone();
                            Console.WriteLine("Press a button to clear a console: ");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case Menu.EditPhone:
                            phoneBook.EditPhone();
                            Console.WriteLine("Press a button to clear a console: ");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case Menu.FindPhone:
                            KeyValuePair<string, string> user = phoneBook.FindPhone();
                            Console.WriteLine("Press a button to clear a console: ");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case Menu.End:
                            Console.WriteLine("Program execution is complete");
                            return;
                    }
                }
                catch(ApplicationException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            while (true);
        }
    }
}

/*
 * Завдання:
 * Створіть програму, яка дозволяє користувачу зберігати та керувати списком контактів у файлі. 
 * Кожен контакт містить ім'я та номер телефону. 
 * Використовуйте словник (Dictionary) для зберігання цих контактів, де ключем є ім'я контакту, а значенням - номер телефону.
 * Програма має надавати такі можливості:
 * Додавання нових контактів у словник та збереження їх у файлі "contacts.txt".
 * Пошук контакту за ім'ям і виведення відповідного номера телефону.
 * Редагування інформації про контакт (зміна номера телефону) та оновлення файлу.
 * Видалення контакту зі словника та оновлення файлу "contacts.txt".
 * Обробка можливих винятків, таких як відсутність файлу "contacts.txt" або відсутність контакту при пошуку.
 * Це завдання дозволить вам попрактикуватися у роботі з файлами, використанні словника (Dictionary), обробці винятків та операціях над елементами цієї структури даних.
 * 
 */