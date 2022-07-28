using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animals.Mammal
{
    internal abstract class Mammal : Animal
    {
        private string livingRegion;
        protected Mammal(string name, double weight, int foodEaten,string livingRegion,double weightModifier) : base(name, weight, foodEaten,weightModifier)
        {
            this.LivingRegion = livingRegion;
        }

        public string LivingRegion { get => livingRegion; private set => livingRegion = value; }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
