﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public abstract class BaseHero : IHero
    {

        private string name;
        private int power;

        public BaseHero(string name, int power)
        {
            this.Name = name;
            this.Power = power;
        }

        public string Name { get => name; private set => name = value; }
        public int Power { get => power; private set => power = value; }

        public virtual string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} hit for {this.Power} damage";
        }
    }
}
