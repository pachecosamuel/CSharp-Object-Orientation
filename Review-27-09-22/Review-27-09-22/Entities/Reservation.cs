using Review_27_09_22.Entities.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_27_09_22.Entities
{
    internal class Reservation
    {
        // Checkout date must be higher than CheckIn date;
        // Booking changes only can occur to future dates

        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }


        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            CheckOutHigherCheckIn(checkIn, checkOut);

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public void BookingChange(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException("Reservation dates for update must be future dates");
            }
        }

        public void CheckOutHigherCheckIn(DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Checkout date must be higher than CheckIn date. ");
                Console.WriteLine();
            }
        }


        public virtual int Duration()
        {
            TimeSpan totalDays = CheckOut.Subtract(CheckIn);

            return (int)totalDays.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            BookingChange(checkIn, checkOut);
            CheckOutHigherCheckIn(checkIn, checkOut);

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string? ToString()
        {
            return "Reservation -> Room: "
                + RoomNumber
                + ", "
                + "CheckIn: "
                + CheckIn.ToShortDateString()
                + ", CheckOut: "
                + CheckOut.ToShortDateString()
                + $", {CheckOut.Subtract(CheckIn).TotalDays} nights.";
        }
    }
}
