using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    internal class Rogue:BaseHero
    {
        private const int DefaulthPower = 80;

        public Rogue(string name) : base(name, DefaulthPower)
        {
        }
    }
}
