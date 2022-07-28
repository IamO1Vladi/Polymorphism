using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animals.Bird
{
    internal class Hen : Bird
    {
        private const double HenWeighGain = 0.35;
        public Hen(string name, double weight, int foodEaten, double wingSize) : base(name, weight, foodEaten, wingSize,HenWeighGain)
        {
        }

        public override string ProduceSound()
        {
            return "Cluck";
        }
    }
}
