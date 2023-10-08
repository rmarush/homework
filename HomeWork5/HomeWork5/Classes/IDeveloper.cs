using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5.Classes
{
    public interface IDeveloper : IComparable<IDeveloper>
    {
        string Tool { get; set; }
        void Create()
        {
            Console.WriteLine($"I use {Tool}");
        }
        void Destroy();
        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }
    }
}
// Create interface IDeveloper with property Tool, methods Create() and Destroy()