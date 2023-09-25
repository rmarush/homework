namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            int a;
            Console.WriteLine("Input the length of the side of the square");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area of a square: " + a * a + " Perimeter of a square: " + a * 4);

            // Task 2
            Console.Write("\nWhat is your name? ");
            string name = Console.ReadLine();
            Console.Write($"How old are you, {name}? ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your name: {name}\nYour age: {age}");

            // Task 3
            Console.WriteLine("\nInput the radius of the circle");
            double radius = Convert.ToDouble(Console.ReadLine());
            double length = 2 * Math.PI * radius;
            double area = Math.PI * Math.Pow(radius, 2);
            double volume = 4.0 / 3.0 * Math.PI * Math.Pow(radius, 3);
            Console.WriteLine($"Length of a circle: {length}\nArea of a circle: {area}\nVolume of a circle: {volume}");
        }
    }
}