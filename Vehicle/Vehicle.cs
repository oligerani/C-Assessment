using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Vehicle
    {
        public string Brand { get; set; }
        public int Speed { get; set; }

        public Vehicle(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
        }
    }

    // Derived class Car
    class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public Car(string brand, int speed, int numberOfDoors) : base(brand, speed)
        {
            NumberOfDoors = numberOfDoors;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Number of Doors: {NumberOfDoors}");
        }
    }

    // Derived class Bike
    class Bike : Vehicle
    {
        public bool HasGear { get; set; }

        public Bike(string brand, int speed, bool hasGear) : base(brand, speed)
        {
            HasGear = hasGear;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Has Gear: {(HasGear ? "Yes" : "No")}");
        }
    }

}

