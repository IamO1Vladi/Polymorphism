using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animals.Mammal
{
    internal class Mouse : Mammal
    {
        private const double MouseWeighGain = 0.10;
        public Mouse(string name, double weight, int foodEaten, string livingRegion) : base(name, weight, foodEaten, livingRegion,MouseWeighGain)
        {
        }

        public override string ProduceSound()
        {
            return "Squeak";
        }

       
        
    }
}
