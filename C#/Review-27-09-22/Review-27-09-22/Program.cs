using Review_27_09_22.Entities;
using Review_27_09_22.Entities.Exception;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                Console.Write("Room number: ");
                int roomNumber = int.Parse(Console.ReadLine());

                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-Out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new(roomNumber, checkIn, checkOut);
                Console.WriteLine(reservation);
                Console.WriteLine();
            }
            catch (DomainException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}