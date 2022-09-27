using Challenge_ArchivesManipulation.Entities;
using System.IO;
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Type file full path: ");
        string SourceFilePath = Console.ReadLine();

        try
        {
            string[] originLines = File.ReadAllLines(SourceFilePath);

            string SourceFolderPath = Path.GetDirectoryName(SourceFilePath);
            string TargetFolderPath = Path.Combine(SourceFolderPath, "out");
            string TargetFilePath = Path.Combine(TargetFolderPath, "summary.csv");

            Directory.CreateDirectory(TargetFolderPath);
            using StreamWriter sw = new(TargetFilePath);

            foreach (string line in originLines)
            {
                string[] fields = line.Split(',');
                string prodName = fields[0];
                double prodPrice = double.Parse(fields[1], CultureInfo.InvariantCulture);
                int prodAmount = int.Parse(fields[2]);

                Product product = new(prodName, prodPrice, prodAmount);
                sw.WriteLine($"{product.ProductName}, {product.FinalPrice()}");
            }

        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }


    }
}