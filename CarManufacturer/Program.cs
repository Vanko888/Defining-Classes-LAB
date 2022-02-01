using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Tire[] tires = new Tire[]
            {
                new Tire(1, 2.4),
                new Tire(1, 2.1),
                new Tire(2, 0.5),
                new Tire(2, 2.3),
            };
            var engine = new Engine(560, 6300);
            var oneCar = new Car("Lamborghini", "Urus", 2010, 250, 9, engine, tires);

            Car car = new Car();
            car.Make = "VW";
            car.Model = "MK3";
            car.Year = 1992;

            Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
        }
    }
}
