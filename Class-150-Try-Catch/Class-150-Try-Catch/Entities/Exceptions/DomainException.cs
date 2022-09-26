using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_150_Try_Catch.Entities.Exceptions
{
    internal class DomainException : Exception
    {
        public DomainException(string message)
            : base(message)
        {
        }

    }
}
