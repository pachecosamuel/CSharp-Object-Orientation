using ChallengeCollections.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        HashSet<int> CourseA = new();

        Console.Write("How many students for Course A? ");
        int a = int.Parse(Console.ReadLine());
        for (int i = 0; i < a; i++)
        {
            int student = int.Parse(Console.ReadLine());
            CourseA.Add(student);
        }

        Console.Write("How many students for Course B? ");
        int b = int.Parse(Console.ReadLine());
        for (int i = 0; i < b; i++)
        {
            int student = int.Parse(Console.ReadLine());
            CourseA.Add(student);
        }


        Console.Write("How many students for Course C? ");
        int c = int.Parse(Console.ReadLine());
        for (int i = 0; i < c; i++)
        {
            int student = int.Parse(Console.ReadLine());
            CourseA.Add(student);
        }

        Console.WriteLine();
        Console.WriteLine($"Total students : {CourseA.Count}");
    }
}