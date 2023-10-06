using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task5.Classes
{
    class Plane: IFlyable
    {
        private string mark;
        private int highFly;
        public Plane(string mark, int highFly)
        {
            this.mark = mark;
            this.highFly = highFly;
        }

        public void Fly()
        {
            Console.WriteLine($"Plane {mark} can fly {highFly}m");
        }
    }
}
// Plane  (with fields: mark and highFly) , which implement interface IFlyable.