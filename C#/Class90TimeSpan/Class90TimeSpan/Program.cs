internal class Program {
    private static void Main(string[] args) {

        TimeSpan t1 = new();
        TimeSpan t2 = new(900000000L);
        TimeSpan t3 = new(2, 30, 55);
        TimeSpan t4 = new(1, 1, 30, 55);
        TimeSpan t5 = new(1, 1, 30, 55, 325);

        TimeSpan z1 = TimeSpan.FromDays(2);
        TimeSpan z2 = TimeSpan.FromHours(2);
        TimeSpan z3 = TimeSpan.FromMinutes(2);
        TimeSpan z4 = TimeSpan.FromSeconds(2);
        TimeSpan z5 = TimeSpan.FromMilliseconds(2);
        TimeSpan z6 = TimeSpan.FromTicks(900000000);

        Console.WriteLine(z1);
        Console.WriteLine(z2);
        Console.WriteLine(z3);
        Console.WriteLine(z4);
        Console.WriteLine(z5);
        Console.WriteLine(z6);


    }
}