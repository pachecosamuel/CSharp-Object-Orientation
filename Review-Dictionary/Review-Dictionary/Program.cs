internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<int, char> dic = new();

        dic.Add(1, 'A');
        dic.Add(2, 'B');
        dic.Add(3, 'C');
        dic[10] = 'D';

        Console.WriteLine(dic[10]);

    }
}