using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    internal class Druid:BaseHero
    {
        private const int DefaulthPower = 80;

        public Druid(string name) : base(name, DefaulthPower)
        {
        }

        public override string CastAbility()
        {
            return  $"{this.GetType().Name} - {Name} healed for {Power}";
        }
    }
}
