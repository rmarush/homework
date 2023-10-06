using Task5.Classes;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskOne();
            TaskTwo();
        }
        public static void TaskOne()
        {
            List<IFlyable> list = new List<IFlyable>();
            list.Add(new Bird("Eagle", true));
            list.Add(new Bird("Chiken", false));
            list.Add(new Plane("Airbus", 10000));
            list.Add(new Plane("Boeing", 8000));
            foreach (IFlyable item in list)
            {
                item.Fly();
            }
        }
        public static void TaskTwo()
        {
            Console.Write("How much integer you want to input? ");
            int size = Int32.Parse(Console.ReadLine());
            List<int> listOfInt = new List<int>();
            for (int i = 0; i < size; i++)
            {
                listOfInt.Add(Int32.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < listOfInt.Count; i++)
            {
                if (listOfInt[i] == 10) Console.WriteLine($"Number {listOfInt[i]} has index {i}");
            }
            for(int i = listOfInt.Count - 1; i >= 0; i--)
            {
                if (listOfInt[i] > 20) listOfInt.Remove(listOfInt[i]);
            }
            Console.WriteLine();
            PrintList(listOfInt);
            int newSize = listOfInt.Count;
            if (newSize >= 1) listOfInt.Insert(2, 1);
            else listOfInt.Add(1);
            if (newSize >= 7) listOfInt.Insert(8, -3);
            else listOfInt.Add(-3);
            listOfInt.Insert(5, -4);
            Console.WriteLine();
            PrintList(listOfInt);
        }
        public static void PrintList(List<int> list)
        {
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}


/*
Develop interface IFlyable with method Fly() (Output information about bird or plane).
Create two classes 	Bird (with fields: name and canFly) and 	Plane  (with fields: mark and highFly) , which implement interface IFlyable.
Create List of IFlyable objects.Add some Birds and Planes to it. Call Fly() method for every item from the list of it. 

Declare collection myColl of 10 integers (read from console).
	1) Find and print all positions of element “-10” in this collection;
	2) Remove from collection elements, which are greater then 20.  Print new collection;
	3) Insert elements 1,-3,-4 in positions 2, 8, 5. Print new collection;
	4) Sort and print collection 
 Use next collections for this tasks: List or ArrayList
 */