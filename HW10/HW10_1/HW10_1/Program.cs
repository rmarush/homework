using HW10_1.Models;

namespace HW10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Triangle> triangles = new List<Triangle>();
            for (int i = 0; i < 3; i++)
            {
                triangles.Add(CreateTriangle());
            }
            foreach(var triangle in triangles)
            {
                triangle.Print();
            }

            Console.WriteLine("Closest Triangle: ");
            Triangle closestTriangle = FindClosestToOrigin(triangles);
            closestTriangle.Print();
        }
        public static Triangle CreateTriangle()
        {
            List<Point> points = new List<Point>();
            for(int i = 0; i < 3; i++)
            {
                Console.Write("Input (X,Y) for point: ");
                string[] input = Console.ReadLine().Split(',');
                points.Add(new Point(double.Parse(input[0]), double.Parse(input[1])));
            }
            var triangle = new Triangle(points[0], points[1], points[2]);
            Console.WriteLine("Triangle was created!");
            return triangle;
        }
        public static Triangle FindClosestToOrigin(List<Triangle> triangles)
        {
            double minDistance = double.MaxValue;
            Point vertexO = new Point(0, 0);
            Triangle closestTriangle = null;
            foreach(var triangle in triangles)
            {
                double distanceToOrigin = triangle.Distance(triangle.vertex1, vertexO);
                if (distanceToOrigin < minDistance)
                {
                    minDistance = distanceToOrigin;
                    closestTriangle = triangle;
                }
                distanceToOrigin = triangle.Distance(triangle.vertex2, vertexO);
                if (distanceToOrigin < minDistance)
                {
                    minDistance = distanceToOrigin;
                    closestTriangle = triangle;
                }
                distanceToOrigin = triangle.Distance(triangle.vertex3, vertexO);
                if (distanceToOrigin < minDistance)
                {
                    minDistance = distanceToOrigin;
                    closestTriangle = triangle;
                }
            }
            return closestTriangle;
        }
    }
}

/*
 * Create struct Point:
    - fields x and y, 
    - method ToString(), which return the Point in format "(x,y)"
   Create class Triangle:
    - fields vertex1, vertex2, vertex3 of type Point
    - constructors
    - method Distance() to calculate distance between points
    - methods Perimeter(), Square(), Print()
   In the Main() create list of 3 triangles and write into console the information about these shapes.
 * Print the triangle with vertex which is the closest to origin (0,0)
 */