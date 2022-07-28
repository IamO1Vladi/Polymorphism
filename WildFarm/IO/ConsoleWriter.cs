using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.IO.Interfaces;

namespace WildFarm.IO
{
    internal class ConsoleWriter : IWritter
    {
        public void Write(string text)
        {
            Console.Write(text);
        }

        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
