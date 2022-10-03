using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_30_10_22.Services
{
    internal class UniversalPrint
    {
        public void PrintUniversal<T>(T value)
        {
            Console.WriteLine(value);
        }
    }
}
