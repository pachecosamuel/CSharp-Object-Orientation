using System.Globalization;
internal class Program {
    private static void Main(string[] args) {

        //Builders básicos
        DateTime d1 = DateTime.Now;
        DateTime d2 = DateTime.UtcNow;
        DateTime d3 = DateTime.Today;
        Console.WriteLine(d1.ToLongDateString());

        //Construtores básicos
        DateTime b1 = new(2020, 10, 25);
        DateTime b2 = new(2020, 10, 25, 12, 12, 12);
        DateTime b3 = new(2020, 10, 25, 12, 12, 12, 122);

        //Auto conversão rep++
        DateTime day1 = DateTime.Parse("2022-09-19");
        DateTime day2 = DateTime.Parse("2022-09-19 12:24:05");
        DateTime day3 = DateTime.Parse("19/09/2022");
        DateTime day4 = DateTime.Parse("19/09/2022 12:24:05");

        //Parse Exact
        DateTime z1 = DateTime.ParseExact("19/09/2022", "dd/MM/yyyy", CultureInfo.InvariantCulture);
        DateTime z2 = DateTime.ParseExact("2022-12-25", "yyyy-M-d", CultureInfo.InvariantCulture);

        //Utilidade prática
        string dia = "19/09/2022 14:18:40";
        DateTime cDay = DateTime.Parse(dia);

        /*Console.WriteLine(day1);
        Console.WriteLine(day2);
        Console.WriteLine(day3);
        Console.WriteLine(day4);*/
    }
}