using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_214_Generics.Services
{
    internal class PrintService<T>
    {
        private int[] vector = new int[10];
        private int count = 0;

        public void AddValue(int x)
        {
            for (int i = 0; i < x; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
                count++;
            }
        }

        public void First()
        {
            Console.WriteLine($"First value: {vector[0]}");
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < count; i++)
            {
                Console.Write(vector[i] + ", ");
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }
}
