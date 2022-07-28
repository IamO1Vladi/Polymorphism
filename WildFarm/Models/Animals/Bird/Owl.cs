using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animals.Bird
{
    internal class Owl : Bird
    {
        private const double OwnWeighGain = 0.25;
        public Owl(string name, double weight, int foodEaten, double wingSize) : base(name, weight, foodEaten, wingSize,OwnWeighGain)
        {
        }

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }
    }
}
