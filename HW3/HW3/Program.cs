namespace HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskOne();
            TaskTwo();
            TaskThree();
        }

        // Read some string str. Calculate the counts of characters ‘a’, ’o’, ’i’, ’e’  in this text
        static void TaskOne()
        {
            Console.Write("Enter a sentence for check: ");
            string str = Console.ReadLine();
            int countA = 0, countO = 0, countI = 0, countE = 0;
            for(int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case 'a':
                        countA++;
                        break;
                    case 'o':
                        countO++;
                        break;
                    case 'i':
                        countI++;
                        break;
                    case 'e':
                        countE++;
                        break;
                }
            }
            Console.WriteLine($"Count of character A: {countA}\nCount of character O: {countO}\nCount of character I: {countI}\nCount of character E: {countE}\nSum of characters found: {countA + countE + countI + countO}");
        }
        // Ask user to enter the number of month. Read value and output the count of days in this month.
        static void TaskTwo()
        {
            Console.Write("Input the number of month: ");
            int month = Int32.Parse(Console.ReadLine());
            Console.Write("Input the number of year: ");
            int year = Int32.Parse(Console.ReadLine());
            // string checkYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0) ? "Year is leap" : "Year isn't leap";
            if(month == 1 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                Console.WriteLine("This month has 31 day");
            } else if (month == 3 || month == 4 || month == 6 || month == 9 || month == 11) 
            {
                Console.WriteLine("This month has 30 day");
            } else
            {
                string checkYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0) ? "This month has 29 day" : "This month has 28 day";
                Console.WriteLine(checkYear);
            }
        }
        // Enter 10 integer numbers. Calculate the sum of first 5 elements if they are positive or product of last 5 element in  the other case.
        static void TaskThree()
        {
            int[] nums = new int[10];
            int sum = 0;
            double product = 1;
            bool fiveNumIsPositive = true;
            for(int i = 0; i < nums.Length; i++)
            {
                Console.Write($"Input number {i + 1}: ");
                nums[i] = Int32.Parse(Console.ReadLine());
                if(i < 5 && nums[i] < 0)
                {
                    fiveNumIsPositive = false;
                }
            }
            if(fiveNumIsPositive)
            {
                for (int i = 0; i < 5; i++) sum += nums[i];
                Console.WriteLine($"Sum of first five elements: {sum}");
            } else
            {
                for (int i = 5; i < 10; i++) product *= nums[i];
                Console.WriteLine($"Product of last five elements: {product}");
            }
        }
    }
}