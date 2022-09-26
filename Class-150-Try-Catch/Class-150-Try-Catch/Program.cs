using Class_150_Try_Catch.Entities;
using Class_150_Try_Catch.Entities.Exceptions;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                Console.Write("Room number : ");
                int roomNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Check-in date (dd/MM/yyyy) : ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Check-Out date (dd/MM/yyyy) : ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new(roomNumber, checkIn, checkOut);
                Console.WriteLine(reservation);

                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Enter with a date to update the reservation: ");
                Console.WriteLine("Check-in date (dd/MM/yyyy) : ");
                checkIn = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Check-Out date (dd/MM/yyyy) : ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation = new(roomNumber, checkIn, checkOut);
                Console.WriteLine(reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Domain exception : " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error : " + e.Message);
            }
        }

        /* 
        while (true)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                Console.WriteLine(n1 / n2);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            catch (FormatException exp)
            {
                Console.WriteLine("Error: " + exp.Message);
            }
            finally
            {
                Console.WriteLine("Finally!") ;
            }

            Console.WriteLine();
        }
        */
    }
}