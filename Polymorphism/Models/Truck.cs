using Polymorphism.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.Models
{
    internal class Truck: IVehicle
    {

        private const double AirCOnditioningIncrease = 1.6;
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;
        

        public Truck(double fuelQuantity, double fuelConsumption,double tankCapacity)
        {
            this.TankCapacity=tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            
        }

        public double FuelQuantity { get => fuelQuantity; private set 
            {
                if (value > tankCapacity)
                {
                    fuelQuantity = 0;
                }
                else
                {
                    fuelQuantity = value;
                }
            } 
        }
        public double FuelConsumption { get => fuelConsumption; private set => fuelConsumption = value; }
        public double TankCapacity { get => tankCapacity; private set => tankCapacity = value; }

        public string Drive(double distance)
        {
            double fuelNeeded = (fuelConsumption + AirCOnditioningIncrease) * distance;

            if (fuelNeeded > fuelQuantity)
            {
                return "Truck needs refueling";
            }
            else
            {
                fuelQuantity -= fuelNeeded;
                return $"Truck travelled {distance} km";
            }
        }

        public void Refuel(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                if (fuelQuantity + liters > tankCapacity)
                {
                    Console.WriteLine($"Cannot fit {liters} fuel in the tank");
                }
                else
                {
                    fuelQuantity += liters - (liters * 0.05);
                }
            }
            
        }
    }
}
