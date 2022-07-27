using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.Models.Interfaces
{
    internal interface IVehicle
    {

        //Car and truck both have fuel quantity, fuel consumption in liters per km,
        //and can be driven a given distance and refueled with a given amount of fuel.
        //It's summer, so both vehicles use air conditioners
        //and their fuel consumption per km is increased by 0.9 liters for the car and with 1.6 liters for the truck.
        //Also, the truck has a tiny hole in its tank and when it’s refueled it keeps only 95% of the given fuel.
        //The car has no problems and adds all the given fuel to its tank.
        //If a vehicle cannot travel the given distance, its fuel does not change.

        public double FuelQuantity { get; }
        public double FuelConsumption { get; }

        public double TankCapacity { get; }

        public string Drive(double distance);

        public void Refuel(double liters);

    }
}
