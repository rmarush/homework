using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW8.Classes
{
    class Circle : Shape
    {
        private double raduis;
        public double Raduis { get { return raduis; } set {  raduis = value; } }
        public Circle(string name, double raduis) : base(name)
        {
            this.raduis = raduis;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Circle => {Name}" +
                $"\nArea => {CalculateArea()}" +
                $"\nPerimetr => {CalculatePerimeter()}");
        }
        public override double CalculateArea()
        {
           return Math.PI * Math.Pow(raduis, 2);
        }
        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * raduis;
        }
    }
}
// Create classes Circle, Square derived from Shape with field radius (for Circle) and side (for Square).