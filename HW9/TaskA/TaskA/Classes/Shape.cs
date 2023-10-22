using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8.Classes
{
    abstract class Shape : IComparable<Shape>
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }
        public Shape(string name)
        {
            this.name = name;
        }
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Shape => {name}");
        }
        int IComparable<Shape>.CompareTo(Shape other)
        {
            return this.CalculateArea().CompareTo(other.CalculateArea());
        }
    }
}
/* 
 * 1) Create abstract class Shape with field name and property Name. 
 * Add constructor with 1 parameter  and abstract methods Area() and Perimeter(), which can return area and perimeter of shape;
 */
