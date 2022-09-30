using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review02_29_09_22.Entities
{
    internal class Vehicle
    {
        public Vehicle()
        {
        }

        public string VehicleModel { get; set; }

        public Vehicle(string vehicleModel)
        {
            VehicleModel = vehicleModel;
        }
    }
}
