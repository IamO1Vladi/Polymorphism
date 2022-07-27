using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    internal class Warrior:BaseHero
    {
        private const int DefaulthPower = 100;

        public Warrior(string name) : base(name, DefaulthPower)
        {
        }
    }
}
