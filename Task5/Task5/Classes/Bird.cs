using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Classes
{
    class Bird: IFlyable
    {
        string name;
        bool canFly;
        public Bird(string name, bool canFly)
        {
            this.name = name;
            this.canFly = canFly;
        }
        public void Fly()
        {
            Console.WriteLine($"Bird {name} can fly {canFly}");
        }
    }
}
// Create two classes 	Bird (with fields: name and canFly)