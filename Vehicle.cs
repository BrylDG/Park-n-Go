using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    
    internal class Vehicle
    {
     
        public string PlateNumber { get; set; }
        public string VehicleType { get; set; }
        public string VehicleBrand { get; set; }

        public List<Vehicle> vehicles1 { get; set; }
        public Vehicle(string platenumber, string vehicletype, string vehiclebrand)
        {
            PlateNumber = platenumber;
            VehicleType = vehicletype;
            VehicleBrand = vehiclebrand;

            kwaa(platenumber, vehicletype, vehiclebrand);

        }

        public Vehicle()
        {
        }

  
        public void kwaa(string plateNumber, string vehicleType, string vehicleBrand) 
        {
            VehicleData vehicleData = new VehicleData();

            vehicleData.PlateNumber = plateNumber;
            vehicleData.VehicleType = vehicleType;
            vehicleData.VehicleBrand = vehicleBrand;
        }

    }
}
