using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 2

            CarLot carLot= new CarLot();

            /*Now that the Car class is created we can instanciate 3 new cars
            Set the properties for each of the cars
            Call each of the methods for each car
            Set the properties utilizing the 3 different ways we learned about, one way for each car*/

            //Object initializer syntax
            Car car1 = new Car()
            {
                Make = "Ford",
                Model = "Rousch Mustang",
                Year = 2008,
                EngineNoise = "vroom",
                HonkNoise = "loud",
                isDrivable = true
        };
            carLot.CarsInLot.Add(car1);
            Console.WriteLine($"Number of cars in lot: {CarLot.numberOfCars}");


            //dot notation
            Car car2 = new Car();
            car2.Make = "Chevy";
            car2.Model = "Z06 Corvette";
            car2.Year = 2008;
            car2.EngineNoise = "vroom";
            car2.HonkNoise = "not very loud";
            car2.isDrivable = true;

            carLot.CarsInLot.Add(car2);
            Console.WriteLine($"Number of cars in lot: {CarLot.numberOfCars}");


            //Custom Constructor
            Car car3 = new Car("Dodge","Ram 1500", 2008, "vroom", "very loud",true);
            carLot.CarsInLot.Add(car3);
            Console.WriteLine($"Number of cars in lot: {CarLot.numberOfCars}");


            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            //foreach (var car in carLot.CarsInLot)
            //{
            //    Console.WriteLine($"Car for sale: \n{car.Year} \n{car.Make} \n{car.Model}");
            //    car.EngineNoiseMade(car.EngineNoise);
            //    car.HonkNoiseMade(car.HonkNoise);
                
            //}


            




        }
    }
}
