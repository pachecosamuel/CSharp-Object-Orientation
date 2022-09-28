using Class_204_Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_204_Interfaces.Services
{
    internal class RentalService
    {
        public double PricePerHours { get; set; }
        public double PricePerDay { get; set; }

        private ITaxService _taxService;

        public RentalService()
        {
        }

        public RentalService(double pricePerHours, double pricePerDay, ITaxService taxService)
        {
            PricePerHours = pricePerHours;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHours * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _bts.Tax(basicPayment);

            carRental.Invoice = new(basicPayment, tax);
        }
    }
}
