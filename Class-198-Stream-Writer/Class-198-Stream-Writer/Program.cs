using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        string sourcePath = @"C:\Users\Samuel Pacheco\Desktop\JobT2M\text1.txt";
        string targetPath = @"C:\Users\Samuel Pacheco\Desktop\JobT2M\LuxuryUpper.txt";

        try
        {
            string[] lines = File.ReadAllLines(sourcePath);

            using StreamWriter sw = File.AppendText(targetPath);
            {
                foreach (string line in lines)
                {
                    sw.WriteLine(line.ToUpper());
                }
            };
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }

    }
}