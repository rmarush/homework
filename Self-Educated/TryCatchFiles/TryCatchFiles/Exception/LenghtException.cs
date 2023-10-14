using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFiles
{
    internal class LenghtException : ApplicationException
    {
        public LenghtException(string message) : base(message)
        {
        }
    }
}
