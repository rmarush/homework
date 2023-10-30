using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10_1.Models
{
    public class Triangle
    {
        public Point vertex1, vertex2, vertex3;
        public Triangle(Point vertex1, Point vertex2, Point vertex3)
        {
            this.vertex1 = vertex1;
            this.vertex2 = vertex2;
            this.vertex3 = vertex3;
        }
        public double Distance(Point p1, Point p2)
        {
            double deltaX = p2.x - p1.x;
            double deltaY = p2.y - p1.y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
        public double Perimeter()
        {
                double side1 = Distance(vertex1, vertex2);
                double side2 = Distance(vertex2, vertex3);
                double side3 = Distance(vertex3, vertex1);
                return side1 + side2 + side3;
        }
        public double Area()
        {
            double sideA = Distance(vertex1, vertex2);
            double sideB = Distance(vertex2, vertex3);
            double sideC = Distance(vertex3, vertex1);
            double p = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }
        public void Print()
        {
            Console.WriteLine("Triangle has point: ");
            Console.WriteLine(vertex1 + " " + vertex2 + " " + vertex3);
            Console.WriteLine("His perimeter: " + Perimeter());
            Console.WriteLine("His area: " + Area());
        }
    }
}

/*
 * Create class Triangle:
    - fields vertex1, vertex2, vertex3 of type Point
    - constructors
    - method Distance() to calculate distance between points
    - methods Perimeter(), Square(), Print() 
 */
