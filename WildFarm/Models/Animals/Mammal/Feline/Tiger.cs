using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animals.Mammal.Feline
{
    internal class Tiger : Feline
    {
        private const double TigerWeighGain = 1.0;
        public Tiger(string name, double weight, int foodEaten, string livingRegion, string breed) : base(name, weight, foodEaten, livingRegion, breed,TigerWeighGain)
        {
        }

        public override string ProduceSound()
        {
            return "ROAR!!!";
        }
    }
}
