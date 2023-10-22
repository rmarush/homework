namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int randomNumber = random.Next(-100, 100); 
                numbers.Add(randomNumber);
            }
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\nNegative:");
            IEnumerable<int> negative = from num in numbers
                                        where num < 0
                                        select num;
            foreach (int number in negative)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\nPositive:");
            IEnumerable<int> positive = from num in numbers
                                        where num > 0
                                        select num;
            foreach (int number in positive)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine($"\nMin number => {numbers.Min()}" +
                              $"\nMax number => {numbers.Max()}" +
                              $"\nSum number => {numbers.Sum()}" +
                              $"\nAverage    => {numbers.Average()}");
            IEnumerable<int> largestThanAverage = numbers.Where(i => i < numbers.Average());
            Console.WriteLine($"Firts largest element than average => {largestThanAverage.Max()} ");
            IEnumerable<int> sortedList = numbers.OrderBy(n => n);
            foreach (int number in sortedList)
            {
                Console.Write(number + " ");
            }
        }
    }
}

/*
 * Create a collection(array) of 10 integers numbers
 * Get and display only negative numbers on the console
 * Get and display only positive numbers on the console
 * Get the largest and smallest elements from the array, and find the sum of all elements of the array.
 * Get the first largest element in array that is smaller than the Average of elements in array 
 * Sort the array using OrderBy
 */