using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5.Classes
{
    public class Builder : IDeveloper
    {
        private string tool;
        public string Tool
        {
            get { return tool; }
            set { tool = value; }
        }
        public Builder(string tool)
        {
            this.tool = tool;
        }
       
        public void Destroy()
        {
            Console.Write("I'm Builder ");
        }
    }
}

// Create two classes Programmer (with field language) and Builder (with field tool), which implement this interface.