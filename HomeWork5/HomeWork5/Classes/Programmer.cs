using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5.Classes
{
    public class Programmer : IDeveloper
    {
        private string language;
        public string Tool
        {
            get { return language; }
            set { language = value; }
        }
        public Programmer(string language)
        {
            this.language = language;
        }
        
        public void Destroy()
        {
            Console.Write("I'm Developer ");
        }
    }
}

// Create two classes Programmer (with field language) and Builder (with field tool), which implement this interface.