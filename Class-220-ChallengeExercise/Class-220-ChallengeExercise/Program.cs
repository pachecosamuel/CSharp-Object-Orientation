using Class_220_ChallengeExercise.Entities;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        string path = @"C:\Users\Samuel Pacheco\Desktop\JobT2M\in.txt";
        HashSet<LogRecord> records = new();

        try
        {
            using StreamReader sr = File.OpenText(path);
            {
                while (!(sr.EndOfStream))
                {
                    string[] lines = sr.ReadLine().Split(" ");

                    string name = lines[0];
                    DateTime moment = DateTime.Parse(lines[1]);

                    records.Add(new LogRecord(name, moment));
                }
                Console.WriteLine($"Amount of logs : {records.Count}");
            }

        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}