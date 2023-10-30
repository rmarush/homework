using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10_1.Models
{
    public struct Point
    {
        public double x;
        public double y;
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double Distance(Point other)
        {
            double deltaX = other.x - x;  
            double deltaY = other.y - y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
        public override string ToString()
        {
            return string.Format($"({x},{y})");
        }
    }
}
/*
 * Create struct Point:
    - fields x and y, 
    - method ToString(), which return the Point in format "(x,y)"
 */