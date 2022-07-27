using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    internal class Paladin:BaseHero
    {
        private const int DefaulthPower = 100;

        public Paladin(string name) : base(name, DefaulthPower)
        {
        }

        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {Name} healed for {Power}";
        }
    }
}
