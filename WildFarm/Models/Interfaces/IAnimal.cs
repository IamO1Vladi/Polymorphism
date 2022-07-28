using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Interfaces
{
    internal interface IAnimal
    {

        //string Name, double Weight, int FoodEaten

        public string Name { get; }

        public double Weight { get; }

        public int FoodEaten { get; }

        public string ProduceSound();

        public void Eat(int quantity);
    }
}
