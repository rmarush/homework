namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[3];
            Car tempCar = new Car();
            for(int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"Input information about car {i+1}");
                cars[i] = tempCar.Input();
            }
            Console.WriteLine("Today we have a discount, all prices are decreased by 10%");
            string findColor = "White";
            for(int i = 0; i < cars.Length; i++)
            {
                cars[i].ChangePrice(10.0);
                if (cars[i].Color == findColor)
                {
                    cars[i].Color = tempCar.ChangeColor();
                    Console.WriteLine($"Car №{i + 1} has changed color to {cars[i].Color}");
                }
                else
                    Console.WriteLine($"Car №{i + 1} hasn't changed color");
            }
            for (int i = 0; i < cars.Length; i++)
            {
                for (int j = i + 1; j < cars.Length; j++)
                {
                    if (cars[i] == cars[j])
                    {
                        Console.WriteLine($"{cars[i]} and {cars[j]} are equals");
                    }
                    else
                    { Console.WriteLine($"Cars are not equals"); }
                }
            }
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
        }
    }
}

/*
 * Define class Car with fields name, color, price and const field CompanyName          
 * Create two constructors - default and with parameters.                                         	
 * Create a property to access the color field.                                           			
 * Define methods: Input () - to enter data about cars from the console,				
 * Print () - to output data about cars on the console					
 * ChangePrice (double x) - to change the price by x%
Enter data about 3 cars.
Decrease car price by 10%, display info about the car on the console.
Enter a new color and “repaint” the car from the color white in the defined color
Overload operator == for the class Car (cars - equal if the name and price are equal)
Override method ToString()  in the class Car, which returns a line with data about cars
*/