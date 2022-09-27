using Class_150_Try_Catch.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_150_Try_Catch.Entities
{
    internal class Reservation
    {

        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }
        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkIn >= checkOut )
            {
                throw new DomainException("Reservation dates must be in the future.");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);

            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {

            if (checkIn < DateTime.Now || checkOut < DateTime.Now)
            {
                throw new DomainException ("Reservation dates must be in the future.");
            }

            if (checkIn >= checkOut)
            {
                    throw new DomainException("Check-out date must be after check-in date.");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string? ToString()
        {
            return "Reservation: Room "
                + RoomNumber
                + ", Check-In: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", Check-Out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + $" , {Duration()} nights.";
        }
    }
}
