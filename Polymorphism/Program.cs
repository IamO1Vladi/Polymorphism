using Polymorphism.Core;
using Polymorphism.IO;
using System;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ConsoleReader consoleReader = new ConsoleReader();
            ConsoleWriter consoleWriter = new ConsoleWriter();

            Engine engine = new Engine(consoleWriter, consoleReader);

            engine.Run();

        }
    }
}
