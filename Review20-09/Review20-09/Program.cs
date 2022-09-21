using System.Globalization;
internal class Program {
    private static void Main(string[] args) {

        TimeSpan t1 = TimeSpan.MaxValue;
        TimeSpan t2 = TimeSpan.MinValue;
        TimeSpan t3 = TimeSpan.Zero;

        TimeSpan t4 = new(2, 15, 50);

        DateTime d1 = DateTime.Now;
        DateTime d2 = d1.ToUniversalTime();

        DateTime d3 = new(2020, 10, 25, 1, 50, 55, DateTimeKind.Utc);
        DateTime d4 = new(2020, 10, 25, 1, 50, 55, DateTimeKind.Local);
        DateTime d5 = new(2020, 10, 25, 1, 50, 55);

        // ISO 8601 yyyy-MM-ddTHH:mm:ssZ
        DateTime d6 = DateTime.Parse("1997-10-14T14:10:02Z");

        Console.WriteLine(d3.Kind);
        Console.WriteLine(d4.Kind);
        Console.WriteLine(d5.Kind);
        Console.WriteLine(d6.Kind);
    }
}