using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animals.Mammal.Feline
{
    internal class Cat : Feline
    {
        private const double CatWeighGain = 0.30;
        public Cat(string name, double weight, int foodEaten, string livingRegion, string breed) : base(name, weight, foodEaten, livingRegion, breed,CatWeighGain)
        {
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
