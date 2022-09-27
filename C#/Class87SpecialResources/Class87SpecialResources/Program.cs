using System.Globalization;
internal class Program {
    private static void Main(string[] args) {

        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double desconto = (preco <= 20.0) ? preco * 0.1 : preco * 0.05;

        string original = " abcde FGHIJ ABC abc DEFG    ";
        string or = "  ";

        string s1 = original.ToLower();
        string s2 = original.ToUpper();
        string s3 = original.Trim();
        
        int n1 = original.IndexOf("FG");
        int n2 = original.LastIndexOf("FG");

        string s4 = original.Substring(5);
        string s5 = original.Substring(5, 5);

        string s6 = original.Replace('a', 'x');
        string s7 = original.Replace("abc", "xyz");

        bool b1 = string.IsNullOrEmpty(original);
        bool b2 = string.IsNullOrWhiteSpace(original); // "  "
        bool b3 = string.IsNullOrWhiteSpace(or);

        Console.WriteLine("Original : -" + original + "-");
        Console.WriteLine();
        Console.WriteLine("ToLower : -" + s1 + "-");
        Console.WriteLine();
        Console.WriteLine("ToUpper : -" + s2 + "-");
        Console.WriteLine();
        Console.WriteLine("Trim : -" + s3 + "-");
        Console.WriteLine();
        Console.WriteLine("Index OF  : -" + n1 + "-");
        Console.WriteLine();
        Console.WriteLine("Last Index OF  : -" + n2 + "-");
        Console.WriteLine();
        Console.WriteLine("Substring (5): -" + s4 + "-");
        Console.WriteLine();
        Console.WriteLine("Substring (5, 5): -" + s5 + "-");
        Console.WriteLine();
        Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
        Console.WriteLine();
        Console.WriteLine("Replace(abc, xyz): -" + s7 + "-");
        Console.WriteLine();
        Console.WriteLine("IsNullOrEmpty original: -" + b1 + "-");
        Console.WriteLine();
        Console.WriteLine("IsNullOrWhiteSpace original: -" + b2 + "-");
        Console.WriteLine();
        Console.WriteLine("IsNullOrWhiteSpace or : -" + b3 + "-");




    
    }
}