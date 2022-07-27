using Polymorphism.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.IO
{
    internal class ConsoleReader : IReader
    {
        public string ReadLine()
        {
           return Console.ReadLine();
        }
    }
}
