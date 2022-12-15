using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CarLotSimulator
{
    public class CarLot
    { //Create a CarLot class
      //It should have at least one property: a List of cars

        public static int numberOfCars; // FROM EXERCISE 2 OF STATIC KEYWORD
        public List<Car> CarsInLot { get; set; } = new List<Car>();

        
    }
}
