using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_27_09_22.Entities.Exception
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string message)
            : base(message)
        {
        }
    }
}
