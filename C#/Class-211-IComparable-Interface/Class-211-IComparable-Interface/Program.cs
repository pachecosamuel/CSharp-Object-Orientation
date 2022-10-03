using Class_211_IComparable_Interface.Entities;
using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        string path = @"C:\Users\Samuel Pacheco\Desktop\JobT2M\text1.txt";

        try
        {
            using StreamReader sr = new(path);
            {
                List<Employee> list = new();

                while (!sr.EndOfStream)
                {
                    list.Add(new Employee(sr.ReadLine()));
                }

                list.Sort();

                foreach (Employee obj in list)
                {
                    Console.WriteLine(obj);
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}