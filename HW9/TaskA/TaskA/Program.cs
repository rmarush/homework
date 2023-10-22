using HW8.Classes;
using System.Collections.Generic;

namespace TaskA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>()
            {
                new Circle("Circle A", 5.0),
                new Square("Square a", 4.0),
                new Circle("Circle B", 3.0),
                new Square("Square B", 6.0),
                new Circle("Circle C", 7.0),
                new Square("Square C", 1.0)
            };
            Console.WriteLine("---- STARTED LIST ----");
            PrintList(shapes);
            Console.WriteLine("---- TASKS ----");
            FindShapeInRange(shapes);
            FindShapeWithLetterA(shapes);
            shapes = FindShapeWithPerimeter(shapes);
            Console.WriteLine("---- ENDED LIST ----");
            PrintList(shapes);
        }
        static public void PrintList(List<Shape> shapes)
        {
            foreach (Shape shape in shapes)
            {
                shape.PrintInfo();
            }
        }
        static public void FindShapeInRange(List<Shape> shapes) 
        {
            // First way
            IEnumerable<Shape> shapesInRange = from shape in shapes
                                               where shape.CalculateArea() > 10 && shape.CalculateArea() < 100
                                               select shape;

            // Second way
            //IEnumerable<Shape> shapesInRange = shapes.Where(i => i.CalculateArea() > 10 && i.CalculateArea() < 100);

            WriteIntoFile(shapesInRange, "Shapes with letter A in name");
            Console.WriteLine("Task one was completed!");
        }
        static public void FindShapeWithLetterA(List<Shape> shapes)
        {
            // First way
            IEnumerable<Shape> shapesLetterA = from shape in shapes
                                               where shape.Name.ToLower().Contains('a')
                                               select shape;

            // Second way
            //IEnumerable<Shape> shapesLetterA = from shape in shapes
            //                                   let textInLower = shape.Name.ToLower()
            //                                   where textInLower.Contains('a')
            //                                   select shape;

            // Third way
            //IEnumerable<Shape> shapesLetterA = shapes.Where(i => i.Name.ToLower().Contains('a'));
            WriteIntoFile(shapesLetterA, "Shapes with letter A in name");
            Console.WriteLine("Task two was completed!");
        }
        static List<Shape> FindShapeWithPerimeter(List<Shape> shapes)
        {
            IEnumerable<Shape> foundedShapes = from shape in shapes
                                               where shape.CalculatePerimeter() > 5
                                               select shape;
            return foundedShapes.ToList();
        }
        static public void WriteIntoFile(IEnumerable<Shape> shapes, string tag)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(@"D:\hw9.txt", true))
                {
                    sw.WriteLine(tag);
                    sw.WriteLine("Shape => Name, Perimeter, Area");
                    foreach (Shape shape in shapes)
                    {
                        if(shape is Circle)
                        {
                            sw.Write("Circle => ");
                        }
                        else
                        {
                            sw.Write("Square => ");
                        }
                        sw.WriteLine($"{shape.Name}, {shape.CalculatePerimeter()}, {shape.CalculateArea()}"); 
                    }
                }
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("Unauthorized access: " + e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Directory not found: " + e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine("I/O error: " + e.Message);
            }
        }
    }
}

/*
 * A) Create Console Application project.
 * Use classes Shape, Circle, Square from your previous homework.
 * Use Linq and string functions to complete next tasks:
 * 1) Create list of Shape and fill it with 6 different shapes (Circle and Square).
 * 2) Find and write into the file shapes with area from range [10,100]
 * 3) Find and write into the file shapes which name contains letter 'a'
 * 4) Find and remove from the list all shapes with perimeter less then 5. Write resulted list into Console 
 */