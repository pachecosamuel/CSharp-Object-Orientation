using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {

        string path = @"C:\Users\Samuel Pacheco\Desktop\JobT2M\text1.txt";

        try
        {
            using FileStream fs = new(path, FileMode.Open);
            {

                using StreamReader sr = new(fs);
                {
                    while (!sr.EndOfStream) 
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                };    

            };      
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }

    }
}
