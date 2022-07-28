using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animals.Bird
{
    internal abstract class Bird : Animal
    {
        private double wingSize;

        protected Bird(string name, double weight, int foodEaten,double wingSize,double weightGain) : base(name, weight, foodEaten,weightGain)
        {
            this.WingSize = wingSize;
        }

        public double WingSize { get => wingSize; private set => wingSize = value; }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}
