using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_155_Challenge_Try_Catch.Entities.Exceptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string message)
            : base(message)
        {
        }
    }
}
