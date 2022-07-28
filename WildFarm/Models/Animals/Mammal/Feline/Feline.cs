using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animals.Mammal.Feline
{
    internal abstract class Feline : Mammal
    {
        private string breed;

        protected Feline(string name, double weight, int foodEaten, string livingRegion,string breed,double weightModifier) : base(name, weight, foodEaten, livingRegion,weightModifier)
        {
            this.Breed = breed;
        }

        public string Breed { get => breed; private set => breed = value; }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
