using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class CarLot
    {
        public CarLot()
        {
           

        }

        public static int NumberOfCars { get; set; }
        public List<Car> ParkingLot{ get; set;} = new List<Car> ();
    }
}
