using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_30_10_22.Services
{
    internal class PrintService<T>
    {
        private List<T> _values = new();
        private int _count = 0;

        public void AddValue(T value)
        {
            _values.Add(value);
            _count++;
        }

        public T First()
        {
            return _values[0];
        }

        public void Print()
        {
            Console.Write("[");
            foreach (T value in _values)
            {
                Console.Write($"{value} ");
            }
            Console.Write("]");
        }
    }
}
