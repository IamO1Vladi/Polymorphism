using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    internal class ConsoleReader : IReader
    {
        public string ReadLine()
        {
           return Console.ReadLine();
        }
    }
}
