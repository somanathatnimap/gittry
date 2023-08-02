using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class AllOOPs
    {
        class Vehicle
        {
            public string Brand { get; set; }
            public int Year { get; set; }

            public Vehicle(string brand, int year)
            {
                Brand = brand;
                Year = year;
            }

            public virtual void DisplayInfo()
            {
                //interpolation
                Console.WriteLine($"Brand: {Brand}, Year: {Year}");
            }
        }

        class Car : Vehicle
        {
            public int NumDoors { get; set; }
            public Car(string brand, int year, int numDoors) : base(brand, year)
            {
                NumDoors = numDoors;
            }
            public override void DisplayInfo()
            {
                Console.WriteLine($"Car - Brand: {Brand}, Year: {Year}, Number of Doors: {NumDoors}");
            }
        }
        class Motorcycle : Vehicle
        {
            public bool HasSidecar { get; set; }

            public Motorcycle(string brand, int year, bool hasSidecar) : base(brand, year)
            {
                HasSidecar = hasSidecar;
            }

            public override void DisplayInfo()
            {
                Console.WriteLine($"Motorcycle - Brand: {Brand}, Year: {Year}, Has Sidecar: {HasSidecar}");
            }
        }

        class Program1
        {
            static void Main()
            {
                // Using polymorphism to store different types of vehicles in the same array
                Vehicle[] vehicles = new Vehicle[]
                {
            new Car("Toyota", 2020, 4),
            new Motorcycle("Harley Davidson", 2019, false),
            new Car("Honda", 2022, 2)
                };

                // Displaying information about each vehicle
                foreach (Vehicle vehicle in vehicles)
                {
                    vehicle.DisplayInfo();
                }
                Console.ReadLine();
            }
        }
    }
}

