internal class Program
{
    private static void Main(string[] args)
    {
        string Path = @"C:\Users\Samuel Pacheco\Desktop\JobT2M";
        string targetPath = @"C:\Users\Samuel Pacheco\Desktop\JobT2M\output";

        try
        {
            var folders = Directory.EnumerateDirectories(Path, "*.*", SearchOption.AllDirectories);

            foreach (var folder in folders)
            {
                Console.WriteLine(folder);
            }

            Console.WriteLine(); Console.WriteLine();

            var files = Directory.EnumerateFiles(Path, "*.*", SearchOption.AllDirectories);

            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
            
            Directory.CreateDirectory(targetPath);
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }

    }
}