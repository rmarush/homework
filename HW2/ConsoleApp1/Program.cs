﻿using System.Diagnostics.Metrics;

namespace ConsoleApp1
{
    internal class Program
    {
        enum HTTPSError { BadRequest = 400, Unauthorized, Forbidden = 403, NotFound, GatewayTimeout = 504 };
        struct Dog
        {
            public string name;
            public string mark;
            public int age;
            public Dog(string name, string mark, int age)
            {
                this.name = name;
                this.mark = mark;
                this.age = age;
            }
            public override string ToString()
            {
                return string.Format($"{name} - {mark} - {age}");
            }
        }
        static void Main(string[] args)
        {
            // Task 1
            bool allNumberInRange = true;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Input a number: ");
                float number = float.Parse(Console.ReadLine());
                if (number >= -5.0 && number <= 5.0) continue;
                else
                {
                    allNumberInRange = false;
                    break;
                }
            }
            string result = allNumberInRange ? "All number are in the range" : "Not all number are in the range";
            Console.WriteLine(result);

            // Task 2
            int min, max;
            Console.Write("Input a number: ");
            int num = Int32.Parse(Console.ReadLine());
            min = max = num;
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Input a number: ");
                num = Int32.Parse(Console.ReadLine());
                max = num > max ? num : max;
                min = num < min ? num : min;
            }
            Console.WriteLine($"Max = {max} -- Min = {min}");


            // Task 3
            Console.Write("Input your HTTPS error: ");
            int numberOfError = Int32.Parse(Console.ReadLine());
            if (Enum.IsDefined(typeof(HTTPSError), numberOfError))
            {
                HTTPSError name = (HTTPSError)numberOfError;
                Console.WriteLine("HTTPS error name: " + name);
            }
            else
            {
                Console.WriteLine("Invalid input, try again!");
            }

            // Task 4
            Dog myDog = new Dog("Andrew", "Pitbull", 19);
            Console.WriteLine("Information about my dog: " + myDog);
            Console.WriteLine("Input information about your dog");
            Dog yourDog = new Dog();
            Console.Write("Input your dog's name: ");
            yourDog.name = Console.ReadLine();
            Console.Write("Input your dog's mark: ");
            yourDog.mark = Console.ReadLine();
            Console.Write("Input your dog's age: ");
            yourDog.age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Information about your dog: " + yourDog);


            //Enter double number  and get the first 2 digits after the point of this number and output the sum of these numbers. For example: 3.456-> 4 + 5 = 9
            Console.Write("Input a number: ");
            double doubleNumber = Double.Parse(Console.ReadLine());
            double partOfDoubleNumber = doubleNumber - Math.Floor(doubleNumber);
            int sum = (int)(partOfDoubleNumber * 10) + (int)(partOfDoubleNumber * 100) % 10;
            Console.WriteLine($"Sum the first 2 digits afther the point: {sum}");
            /* При введенні 5.55 Math.Floor робить з цього числа 0.54999..., тому в результаті ми получаємо суму 10
             * це уникається введенням третьої цифри: 5.55Х.*/
        }
    }
}
