namespace ConsoleApp1
{
    internal class Program
    {
        enum drinks { Coffee = 45, Tea = 30, Juice = 15, Water = 5};
        static void Main(string[] args)
        {
            // Task 1 Enter two integer numbers a and b.Calculate how many integers in the range[a..b] are divided by 3 without remainder. //1..10 -> 3
            Console.Write("Input a: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Input b: ");
            int b = Int32.Parse(Console.ReadLine());
            int count = 0;
            for (int i = a; i <= b; i++)
            {
                count = (i % 3) == 0 ? ++count : count;
            }
            Console.WriteLine(count);

            // Task 2 Enter some string text from the console. Print each second character.
            Console.WriteLine("Input a string: ");
            string str = Console.ReadLine();
            for (int i = 1; i < str.Length; i += 2)
            {
                Console.WriteLine(str[i]);
            }

            // Task 3 Enter the name of the drink (coffee, tea, juice, water). Print the name and price of the drink.
            Console.Write("Enter the name of the drink(coffee/tea/juice/water): ");
            string drink = Console.ReadLine();
            switch (drink.ToLower())
            {
                case "coffee":
                    Console.WriteLine($"Your drink: {drinks.Coffee}, price: {(int)drinks.Coffee}");
                    break;
                case "tea":
                    Console.WriteLine($"Your drink: {drinks.Tea}, price: {(int)drinks.Tea}");
                    break;
                case "juice":
                    Console.WriteLine($"Your drink: {drinks.Juice}, price: {(int)drinks.Juice}");
                    break;
                case "water":
                    Console.WriteLine($"Your drink: {drinks.Water}, price: {(int)drinks.Water}");
                    break;
                default:
                    Console.WriteLine("Input error, try again!");
                    break;
            }
            Console.ReadKey();
            //Task 4 Enter a sequence of positive integers(to the first negative). Calculate the arithmetic average of the entered positive numbers.
            //1,6,3,9,-8-> (1 + 6 + 3 + 9) / 4
            int sum = 0;
            while (true)
            {
                Console.Write("Input a number: ");
                int number = Int32.Parse(Console.ReadLine());
                if (number > 0) sum += number;
                else break;
            }
            Console.WriteLine(sum);
            // Task 5
            Console.Write("Input a year: ");
            int year = Int32.Parse(Console.ReadLine());
            string checkYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0) ? "Year is leap" : "Year isn't leap";
            Console.WriteLine(checkYear);

            // Task 6 Find the sum of digits of the entered integer number //(365 -> 3+6+5)
            Console.Write("Input number for check digits sum: ");
            int numberForSum = Int32.Parse(Console.ReadLine());
            int sumDigits = 0;
            while (numberForSum > 0)
            {
                sumDigits += numberForSum % 10;
                numberForSum /= 10;
            }
            Console.WriteLine(sumDigits);

            // Task 7 Check if the entered integer number contains only odd digits.
            Console.Write("Input a number: ");
            int numberForCheck = Int32.Parse(Console.ReadLine());
            int temp = numberForCheck;
            bool isAllOddNum = false;
            while(temp > 0)
            {
                if ((temp % 10) % 2 != 0) isAllOddNum = true;
                else break;
                temp /= 10;
            }
            string sentence = isAllOddNum ? "Number has only odd digits" : "Number hasn't only odd digits";
            Console.WriteLine(sentence);
        }
    }
}