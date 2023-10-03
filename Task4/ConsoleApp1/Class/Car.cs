using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum Colors { White = 1, Black, Red, Blue, Green, Gray, Yellow};
    internal class Car
    {
        private string name;
        private string color;
        private double price;
        public const string CompanyName = "Ford";
        public string Name { get; set; }
        public string Color
        {
            set { color = value; }
            get { return color; }
        }
        public double Price { get; set; }
        public Car()
        {
            this.name = "Ford Fusion";
            this.color = "white";
            this.price = 15000;
        }
        public Car(string name, string color, double price)
        {
            this.name = name;
            this.color = color;
            this.price = price;
        }
        public Car Input()
        {
            Car car = new Car();
            Console.Write("Input a name of the car: ");
            car.name = Console.ReadLine();
            Console.Write("Input a color of the car: ");
            car.color = ChangeColor();
            Console.Write("Input a price of the car: ");
            car.price = Int32.Parse(Console.ReadLine());
            return car;
        }
        public void Print()
        {
            Console.WriteLine($"Info about your car:\nName: {name} -- Color: {color} -- Price: {price}");
        }
        public void ChangePrice(double x)
        {
            price -= price * x / 100;
        }
        public string ChangeColor()
        {
            Colors color = new Colors();
            Console.WriteLine("\n----CHOICE COLOR----\n" +
                    "1 - White\n" +
                    "2 - Black\n" +
                    "3 - Red\n" +
                    "4 - Blue\n" +
                    "5 - Green\n" +
                    "6 - Gray\n" +
                    "7 - Yellow\n");
            Console.Write("Input your choice: ");
            Enum.TryParse(Console.ReadLine(), out color);
            return color.ToString();
        }
        public static bool operator ==(Car car1, Car car2)
        {
            return (car1.name == car2.name) && (car1.price == car2.price);
        }
        public static bool operator !=(Car car1, Car car2)
        {
            return !(car1 == car2);
        }
        public override string ToString()
        {
            return string.Format($"Name: {name} || Color: {color} || Price: {price}");
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