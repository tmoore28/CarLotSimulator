using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car......... Done!
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable.....Done

           


            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property......Done
            var carLot = new CarLot();
            var saturn = new Car();
            saturn.Make = "Saturn";
            saturn.Year = "2008";
            saturn.Model = "Vue";
            saturn.EngineNoise = "Vroom, Vroom";
            saturn.MakeEngineNoise(saturn.EngineNoise);
            saturn.HonkNoise = "Honk, Honk";
            saturn.MakeHonkNoise(saturn.HonkNoise);
            saturn.IsDriveable = true;

            carLot.ParkingLot.Add(saturn);

            Console.WriteLine($"Number of cars in our lot: {CarLot.NumberOfCars}");

            var nissan = new Car("1995", "Nissan", "Altima", "Chug, Chug", "Clug, Clug", false);

            carLot.ParkingLot.Add(nissan);

            Console.WriteLine($"Number of cars in our lot: {CarLot.NumberOfCars}");

            var cruz = new Car()
            {
                Make = "Chevy",
                Model = "Cruz",
                EngineNoise = "Zoom, Zoom",
                Year = "2016",
                HonkNoise = "Ehhhhhh, Ehhhhh",
                IsDriveable = true
            };

            carLot.ParkingLot.Add(cruz);

            Console.WriteLine($"Number of cars in our lot: {CarLot.NumberOfCars}");

            foreach (var car in carLot.ParkingLot)
            {
                Console.WriteLine($"{car.Make}, {car.Year}, {car.Model}");
                car.MakeEngineNoise(car.EngineNoise);
                car.MakeEngineNoise(car.EngineNoise);
                Console.WriteLine();
            }
        }
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

                //*************BONUS*************//

                // Set the properties utilizing the 3 different ways we learned about, one way for each car

                //*************BONUS X 2*************//

                //Create a CarLot class
                //It should have at least one property: a List of cars
                //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
                //At the end iterate through the list printing each of car's Year, Make, and Model to the console
    }
}
