using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeException.Exceptions
{
    internal class HaveNotInArrayException : Exception
    {
        public HaveNotInArrayException(string message) : base(message)
        {

        }

    }
}
