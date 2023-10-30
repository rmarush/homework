using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8.Classes
{
    public class Square : Shape
    {
        private double side;
        public double Side { get { return side; } set {  side = value; } }
        public Square(string name, double side) : base(name)
        {
            this.side = side;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Square => {Name}" +
                $"\nArea => {CalculateArea()}" +
                $"\nPerimetr => {CalculatePerimeter()}");
        }
        public override double CalculateArea()
        {
            return side * side;
        }
        public override double CalculatePerimeter()
        {
            return 4 * side;
        }
    }
}
// Create classes Circle, Square derived from Shape with field radius (for Circle) and side (for Square).