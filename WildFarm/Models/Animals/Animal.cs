using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models.Animals
{
    internal abstract class Animal : IAnimal
    {
        private string name;
        private double weight;
        private int foodEaten;
        private double weightModifier;

        protected Animal(string name, double weight, int foodEaten,double weightModifier)
        {
            this.Name = name;
            this.Weight = weight;
            this.FoodEaten = foodEaten;
            this.WeightModifier = weightModifier;
        }

        public string Name { get => name; private set => name = value; }
        public double Weight { get => weight; private set => weight = value; }
        public int FoodEaten { get => foodEaten; private set => foodEaten = value; }
        public double WeightModifier { get => weightModifier; private set => weightModifier = value; }

        public void Eat(int quantity)
        {
            this.foodEaten += quantity;
            for (int i = 0; i < quantity; i++)
            {               
                decimal newWeight = (decimal)(this.weight + weightModifier);
                this.weight = (double)newWeight;
            }
        }

        public abstract string ProduceSound();
        

        
    }
}
