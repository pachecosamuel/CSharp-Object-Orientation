using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        string sourcePath = @"C:\Users\Samuel Pacheco\Desktop\JobT2M\text1.txt";
        string targetPath = @"C:\Users\Samuel Pacheco\Desktop\JobT2M\text2.txt";


        try
        {
            FileInfo fileInfo = new FileInfo(sourcePath);
            fileInfo.CopyTo(targetPath);

            string[] lines = File.ReadAllLines(sourcePath);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("Exception : " + e.Message);
        }
    }
}