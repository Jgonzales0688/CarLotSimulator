using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {   //Exercise 2
        //Create a seperate class file called Car
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        public Car()
        {
            CarLot.numberOfCars++;
        }

        public Car(string make, string model, int year, string engineNoise, string honkNoise, bool IsDrivable)
        {
            Make = make;
            Model = model;
            Year = year;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDrivable = isDrivable;

            CarLot.numberOfCars++;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool isDrivable { get; set; }

        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property
        public void EngineNoiseMade(string noise)
        {
            Console.WriteLine($"This engine on this vehichle makes a {noise} sound.");
        }

        public void HonkNoiseMade(string noise)
        { 
        Console.WriteLine($"When you honk it is {noise}.\n");
        }

       

        

    }
}
