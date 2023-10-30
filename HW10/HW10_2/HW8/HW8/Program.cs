using HW8.Classes;

namespace HW8
{
    internal class Program
    {
        enum Menu { AddCircle = 1, AddSquare }
        static void Main(string[] args)
        {
            List<Shape> shapes = CreateList();
            PrintList(shapes);
            Console.WriteLine("------------------");
            Shape shapeWithMaxPerimeter = FindMaxPerimeter(shapes);
            shapeWithMaxPerimeter.PrintInfo();
            Console.WriteLine("------------------");
            shapes.Sort();
            PrintList(shapes);

        }
        static public Shape FindMaxPerimeter(List<Shape> shapes)
        {
            Shape maxShapePerimeter = shapes[0];
            foreach(Shape shape in shapes)
            {
                if(shape.CalculateArea() > maxShapePerimeter.CalculateArea())
                {
                    maxShapePerimeter = shape;
                }
            }
            return maxShapePerimeter;
        }
        static public void PrintList(List<Shape> shapes)
        {
            foreach(Shape shape in shapes)
            {
                shape.PrintInfo();
            }
        }
        static public List<Shape> CreateList()
        {
            List<Shape> shapes = new List<Shape>();
            Menu menu = new Menu();
            int count = 10, n = 0;
            while(n < count)
            {
                Console.WriteLine("-----MENU-----" +
                                "\n1 - Add Circle" +
                                "\n2 - Add Square");
                Enum.TryParse(Console.ReadLine(), out menu);
                if (menu != Menu.AddCircle && menu != Menu.AddSquare) continue;
                Console.Write("Input a name: ");
                string name = Console.ReadLine();
                switch (menu)
                {
                    case Menu.AddCircle:
                        Console.Write("Input a radius: ");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        Circle circle = new Circle(name, radius);
                        shapes.Add(circle);
                        n++;
                        break;
                    case Menu.AddSquare:
                        Console.Write("Input a side: ");
                        double side = Convert.ToDouble(Console.ReadLine());
                        Square square = new Square(name, side);
                        shapes.Add(square);
                        n++;
                        break;
                    default:
                        Console.WriteLine("Input error, try again!");
                        break;
                }
            }
            return shapes;
        }
    }
}
/*
 * 1) Create abstract class Shape with field name and property Name. 
 * Add constructor with 1 parameter  and abstract methods Area() and Perimeter(), which can return area and perimeter of shape; 
 * Create classes Circle, Square derived from Shape with field radius (for Circle) and side (for Square).   
 * Add necessary constructors, properties to these classes, override methods from abstract class Shape. 
 * a) In Main() create list of Shape, then ask user to enter data of 10 different shapes.  Write name, area and perimeter of all shapes. 
 * b) Find shape with the largest perimeter and print its name. 
 * 3) Sort shapes by area and print obtained list (Remember about IComparable)
 */