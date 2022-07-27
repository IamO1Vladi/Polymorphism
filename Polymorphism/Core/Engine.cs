using Polymorphism.IO.Interfaces;
using Polymorphism.Models;
using Polymorphism.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.Core
{
    internal class Engine : IEngine
    {
        private readonly IWriter writer;
        private readonly IReader reader;

        public Engine(IWriter writer, IReader reader)
        {
            this.writer = writer;
            this.reader = reader;
        }

        public void Run()
        {
            string[] carImput=reader.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            string[] truckImput = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] busImput = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double carFuelQuantity = double.Parse(carImput[1]);
            double carFuelConsuption = double.Parse(carImput[2]);
            double carTankCapacity=double.Parse(carImput[3]);

            double truckFuelQuantity = double.Parse(truckImput[1]);
            double truckFuelConsuption = double.Parse(truckImput[2]);
            double truckTankCapacity = double.Parse(truckImput[3]);

            double buskFuelQuantity = double.Parse(busImput[1]);
            double buskFuelConsuption = double.Parse(busImput[2]);
            double buskTankCapacity = double.Parse(busImput[3]);

            IVehicle car = new Car(carFuelQuantity, carFuelConsuption,carTankCapacity);
            IVehicle truck=new Truck(truckFuelQuantity, truckFuelConsuption,truckTankCapacity);
            IVehicle bus=new Bus(buskFuelQuantity, buskFuelConsuption,buskTankCapacity);

            int numberOfCommands = int.Parse(reader.ReadLine());

            for(int i = 0; i < numberOfCommands; i++)
            {

                string[] cmdArg = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if(cmdArg[0] == "Drive")
                {
                    double distance = double.Parse(cmdArg[2]);
                    if (cmdArg[1] == "Car")
                    {
                        writer.WriteLine(car.Drive(distance));
                    }
                    else if (cmdArg[1] == "Truck")
                    {
                        writer.WriteLine(truck.Drive(distance));
                    }else if (cmdArg[1] == "Bus")
                    {
                        writer.WriteLine(bus.Drive(distance));
                    }

                }
                else if (cmdArg[0] == "Refuel")
                {
                    double liters=double.Parse(cmdArg[2]);
                    if (cmdArg[1] == "Car")
                    {

                        car.Refuel(liters);
                    }
                    else if (cmdArg[1] == "Truck")
                    {
                        truck.Refuel(liters);
                    }
                    else if (cmdArg[1] == "Bus")
                    {
                        bus.Refuel(liters);
                    }
                }else if (cmdArg[0] == "DriveEmpty")
                {
                    double distance = double.Parse(cmdArg[2]);

                    writer.WriteLine(((Bus)bus).DriveEmptyBus(distance));
                }

            }

            writer.WriteLine($"Car: {car.FuelQuantity:F2}");
            writer.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            writer.WriteLine($"Bus: {bus.FuelQuantity:F2}");
        }
    }
}
