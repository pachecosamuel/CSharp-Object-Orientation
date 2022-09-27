internal class Program
{
    private static void Main(string[] args)
    {
        string path = @"C:\Users\Samuel Pacheco\Desktop\JobT2M";

        try
        {
            IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);

            Console.WriteLine("Folders: ");
            foreach (string obj in folders)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
            Console.WriteLine();
            
            var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories); 
            Console.WriteLine("Files: ");
            foreach (string obj in files)
            {
                Console.WriteLine(obj);
            }

            Directory.CreateDirectory(path + @"\NovaPaxta");
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}