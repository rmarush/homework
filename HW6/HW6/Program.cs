using System;

namespace HW6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your range: ");
            Console.Write("Start = ");
            int start = Int32.Parse(Console.ReadLine());
            Console.Write("End = ");
            int end = Int32.Parse(Console.ReadLine());
            List<int> list = ReadNumber(start, end);
            foreach(int number in list)
            {
                Console.WriteLine(number);
            }
        }
        static List<int> ReadNumber(int start, int end)
        {
            List<int> list = new List<int>();
            const int size = 10;
            int prevNumber = 0;
            Console.WriteLine("You have to input 10 numbers!");
            for (int i = 0; i < size; i++)
            {
                try
                {
                    Console.Write($"Input a number #{i + 1}: ");
                    int number = Int32.Parse(Console.ReadLine());
                    if (number < prevNumber) throw new ApplicationException($"{number} must be > than {prevNumber}");
                    if (number < start || number > end) throw new ArgumentOutOfRangeException($"{number} must be in range {start}...{end}");
                    prevNumber = number;
                    list.Add(number);
                }
                catch(ApplicationException e)
                {
                    Console.WriteLine(e.Message);
                    i--;
                }
                catch(FormatException e)
                {
                    Console.WriteLine(e.Message);
                    i--;
                }
                catch(ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                    i--;
                }
            }
            return list;
        }
    }
}

/*
 * Write method ReadNumber(int start, int end), which reads from console  integer numbers and returns it, if it is in the range [start...end]. 
 * If this numbers is invalid or non-number text is read, the method should throw an exception. 
 * Using this method write a method Main(), that has to enter 10 numbers:
 *	a1, a2, ..., a10, such that 1 < a1 < ... < a10 < 100
 */