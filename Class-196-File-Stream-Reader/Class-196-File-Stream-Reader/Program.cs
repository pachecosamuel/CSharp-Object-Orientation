using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        string sourcePath = @"C:\Users\Samuel Pacheco\Desktop\JobT2M\text1.txt";
        FileStream fs = null;
        StreamReader sr = null;

        try
        {
            fs = new(sourcePath, FileMode.Open);
            sr = new(fs);

            string lines = sr.ReadToEnd();
            Console.WriteLine(lines);
        }
        catch (IOException e)
        {
            Console.WriteLine("An error ocurred: " + e.Message);
        }
        finally
        {
            if (sr != null) sr.Close();
            if (fs != null) fs.Close();
        }
    }
}