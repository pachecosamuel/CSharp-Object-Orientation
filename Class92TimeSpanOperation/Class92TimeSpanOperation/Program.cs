internal class Program {
    private static void Main(string[] args) {

        //Padrão ISO 8601 -> yyyy-MM-ddTHH:mm:ssZ

        DateTime b1 = DateTime.Parse("2000-05-10 15:30:45");
        DateTime b2 = DateTime.Parse("2000-05-10T15:30:45Z");
        DateTime b3 = DateTime.Now;

        Console.WriteLine("b1: " + b1);
        Console.WriteLine("b1 Kind: " + b1.Kind);
        Console.WriteLine("b1 ToLocal: " + b1.ToLocalTime());
        Console.WriteLine("b1 ToUtcTime: " + b1.ToUniversalTime());

        Console.WriteLine();

        Console.WriteLine("b2: " + b2);
        Console.WriteLine("b2 Kind: " + b2.Kind);
        Console.WriteLine("b2 ToLocal: " + b2.ToLocalTime());
        Console.WriteLine("b2 ToUtcTime: " + b2.ToUniversalTime());

        Console.WriteLine();

        Console.WriteLine("b3: " + b3);
        Console.WriteLine("b3 Kind: " + b3.Kind);
        Console.WriteLine("b3 ToLocal: " + b3.ToLocalTime());
        Console.WriteLine("b3 ToUtcTime: " + b3.ToUniversalTime());
        Console.WriteLine();

        Console.WriteLine("-------------------------------------------");

        DateTime d1 = new DateTime(2000, 05, 15, 18, 30, 45, DateTimeKind.Local);
        DateTime d2 = new DateTime(2000, 05, 15, 18, 30, 45, DateTimeKind.Utc);
        DateTime d3 = new DateTime(2000, 05, 15, 18, 30, 45);

        Console.WriteLine("d1: " + d1);
        Console.WriteLine("d1 Kind: " + d1.Kind);
        Console.WriteLine("d1 ToLocal: " + d1.ToLocalTime());
        Console.WriteLine("d1 ToUtcTime: " + d1.ToUniversalTime());
        Console.WriteLine();
        Console.WriteLine("d2: " + d2);
        Console.WriteLine("d2 Kind: " + d2.Kind);
        Console.WriteLine("d2 ToLocal: " + d2.ToLocalTime());
        Console.WriteLine("d2 ToUtcTime: " + d2.ToUniversalTime());
        Console.WriteLine();
        Console.WriteLine("d3: " + d3);
        Console.WriteLine("d3 Kind: " + d3.Kind);
        Console.WriteLine("d3 ToLocal: " + d3.ToLocalTime());
        Console.WriteLine("d3 ToUtcTime: " + d3.ToUniversalTime());
        Console.WriteLine();

        Console.WriteLine("-------------------------------------------");

        TimeSpan t1 = new(2, 1, 30, 15, 750);
        TimeSpan t2 = new(1, 30, 10);
        TimeSpan t3 = new(0, 10, 5);
        
        Console.WriteLine("Sum: " + t2.Add(t3));
        Console.WriteLine("Subtraction: " + t2.Subtract(t3));
        Console.WriteLine("Mult : " + t2.Multiply(2.0));
        Console.WriteLine("Division : " + t2.Divide(2.0));
        Console.WriteLine("--------------------------");
        Console.WriteLine("Days : " + t1.Days);
        Console.WriteLine("Hours : " + t1.Hours);
        Console.WriteLine("Minutes : " + t1.Minutes);
        Console.WriteLine("Seconds : " + t1.Seconds);
        Console.WriteLine("Microseconds : " + t1.Milliseconds);
        Console.WriteLine("Total Hours : " + t1.TotalHours);
        Console.WriteLine("Total Minutes : " + t1.TotalMinutes);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        
    }
}