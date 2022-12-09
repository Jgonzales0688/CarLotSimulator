using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class CarLot
    { //Create a CarLot class
      //It should have at least one property: a List of cars
        public List<Car> CarsInLot { get; set; } = new List<Car>();

    }
}
