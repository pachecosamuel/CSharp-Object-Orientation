using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {

        string path = @"C:\Users\Samuel Pacheco\Desktop\JobT2M\text1.txt";
        FileStream fs = null;
        StreamReader sr = null;

        try
        {
            fs = new FileStream(path, FileMode.Open);
            sr = new StreamReader(fs);

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
        }
        catch (IOException e)
        {
            Console.WriteLine($"Error -> {e.Message}");
        }
        finally
        {
            if (fs != null) { fs.Close(); };
            if (sr != null) { sr.Close(); };    
        }

        /*
        string sourcePath = @"C:\Users\Samuel Pacheco\Desktop\JobT2M\text1.txt";
        string targetPath = @"C:\Users\Samuel Pacheco\Desktop\JobT2M\LuxuryBrands.txt";

        try
        {
            //File.Copy(sourcePath, targetPath);
            FileInfo fileInfo = new FileInfo(sourcePath);
            fileInfo.CopyTo(targetPath);

            string[] lines = File.ReadAllLines(sourcePath);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine();
        }
        catch (IOException e)
        {
            Console.WriteLine($"IOException -> {e.Message}");
        }
        finally 
        {
        }
        */
    }
}