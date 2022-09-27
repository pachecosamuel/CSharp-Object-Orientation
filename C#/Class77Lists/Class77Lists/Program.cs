using System.Collections.Generic;

internal class Program {
    private static void Main(string[] args) {

        List<string> names = new List<string>();

        names.Add("Samanta");
        names.Add("Samuel");
        names.Add("Julia");
        names.Add("Anchieta");
        names.Add("Ana");
        names.Add("Mateus");
        names.Insert(0, "Megan Fox");

        foreach (string name in names) {
            Console.WriteLine(name);
        }

        Console.WriteLine("----------------------------------");

        Console.WriteLine($"Using list count: {names.Count}");
        Console.WriteLine($"First appearing with 'S': {names.Find(x => x[0] == 'S')}");
        Console.WriteLine($"Last appearing with 'A': {names.FindLast(x => x[0] == 'A')}");
        Console.WriteLine($"First position with M: {names.FindIndex(x => x[0] == 'M')}");
        Console.WriteLine($"First position with M: {names.FindLastIndex(x => x[0] == 'M')}");

        Console.WriteLine("----------------------------------");

        List<string> listFinal = names.FindAll(x => x[0] == 'M');
        foreach (string obj in listFinal) {
            Console.WriteLine(obj);
        }

        Console.WriteLine("----------------------------------");

        names.Remove("Mateus");
        foreach (string name in names) {
            Console.WriteLine(name);

        }

        Console.WriteLine("----------------------------------");

        names.RemoveAll(x => x[0] == 'A');
        foreach (string name in names) {
            Console.WriteLine(name);
        }

        Console.WriteLine("----------------------------------");
        names.RemoveAt(1);
        foreach (string name in names) {
            Console.WriteLine(name);
        }
    }

    static bool Test(string s) {
        return s[0] == 'A';
    }
}