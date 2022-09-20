using System.Globalization;

internal class Program {
    private static void Main(string[] args) {

        DateTime dateTime = DateTime.Now;
        DateTime dateTime2 = dateTime.AddDays(7);
        Console.WriteLine(dateTime2);

        string q1 = dateTime.ToLongDateString();
        string q2 = dateTime.ToLongTimeString();
        string q3 = dateTime.ToShortDateString();
        string q4 = dateTime.ToShortTimeString();
        string q5 = dateTime.ToString();
        string q6 = dateTime.ToString("yyyy-MM-dd HH:m:s");


        Console.WriteLine(q1);
        Console.WriteLine(q2);
        Console.WriteLine(q3);
        Console.WriteLine(q4);
        Console.WriteLine(q5);
        Console.WriteLine(q6);


        
        TimeSpan t1 = new();
        TimeSpan t2 = new(900000000L);
        TimeSpan t3 = new(1, 20, 35);
        TimeSpan t4 = new(2, 1, 20, 35);
        TimeSpan t5 = new(2, 1, 20, 35, 350);

        TimeSpan b1 = TimeSpan.FromDays(1);
        TimeSpan b2 = TimeSpan.FromHours(1);
        TimeSpan b3 = TimeSpan.FromMinutes(60);

        Console.WriteLine(b1);
        Console.WriteLine(b2);
        Console.WriteLine(b3);



        /*Uso de recursos da classe */
        DateTime d1 = DateTime.Now;
        DateTime d2 = DateTime.UtcNow;
        DateTime d3 = DateTime.Today;

        /* Uso dos contrutores 
        DateTime b1 = new(2020, 10, 25);
        DateTime b2 = new(2020, 10, 25, 12, 12, 12);
        DateTime b3 = new(2020, 10, 25, 12, 12, 12, 122);
        */

        /* Usando Parse */
        string holiday = "2022-07-07";

        DateTime day1 = DateTime.Parse("1997/10/14 14:20:08");
        DateTime day2 = DateTime.Parse("1997-10-14");
        DateTime day3 = DateTime.Parse("14-10-1997 14:20:08");
        DateTime day4 = DateTime.Parse(holiday);
        DateTime day5 = DateTime.ParseExact("2022-12-25", "dd-MM-yyyy", CultureInfo.InvariantCulture);
        




        string original = "  abcde FGHIJ ABC abc DEFG ";
        string test = "  ";

        string s1 = original.ToLower();
        string s2 = original.ToUpper();
        string s3 = original.Trim();
        
        int n1 = original.IndexOf("abc");
        int n2 = original.LastIndexOf("abc");

        string s4 = original.Substring(7);
        string s5 = original.Substring(3, 5);

        string s6 = original.Replace('a', 'x');
        string s7 = original.Replace("abc", "xyz");

   

        Console.WriteLine("Original : -" + original + "-");
        Console.WriteLine();
        Console.WriteLine("ToLower : -" + s1 + "-");
        Console.WriteLine();
        Console.WriteLine("ToUpper : -" + s2 + "-");
        Console.WriteLine();
        Console.WriteLine("Using Trim : -" + s3 + "-");
        Console.WriteLine();
        Console.WriteLine("First index of 'abc' : -" + n1 + "-");
        Console.WriteLine();
        Console.WriteLine("Last index of 'abc' : -" + n2 + "-");
        Console.WriteLine();
        Console.WriteLine("Substring (7) : -" + s4 + "-");
        Console.WriteLine();
        Console.WriteLine("Substring (3, 5) : -" + s5 + "-");
        Console.WriteLine();
        Console.WriteLine("Replace (a, x) : -" + s6 + "-");
        Console.WriteLine();
        Console.WriteLine("Replace (abc, xyz) : -" + s7 + "-");
  




        Console.WriteLine( (2 > 4) ? 10 : 20 );
        double z = ((6) > (5)) ? 19562.20 : 10000.00;
        Console.WriteLine(z);

        var x = 10;
        var w = 'S';
        var y = 15.5;

        Console.WriteLine(x);
        Console.WriteLine(w);
        Console.WriteLine(y);




        int[,] matrix = new int[2, 3];

        for (int i = 0; i < 2; i++) {
            Console.WriteLine($"Type the values to the {i+1}° line");
            string[] numbers = Console.ReadLine().Split(" ");

            for (int j = 0; j < 3; j++) {
                matrix[i, j] = int.Parse(numbers[j]);
            }
        }

        Console.WriteLine("-----------------------------------\nLet's try again\n--------------------------------");

        for (int i = 0; i < 2; i++) {

            for (int j = 0; j < 3; j++) {
                Console.Write(matrix[i, j] + " ");
            }

            Console.WriteLine();
        }

    }
}