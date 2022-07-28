using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animals.Mammal
{
    internal class Dog : Mammal
    {
        private const double DogWeighGain = 0.40;
        public Dog(string name, double weight, int foodEaten, string livingRegion) : base(name, weight, foodEaten, livingRegion,DogWeighGain)
        {
        }

        public override string ProduceSound()
        {
            return "Woof!";
        }
    }
}
