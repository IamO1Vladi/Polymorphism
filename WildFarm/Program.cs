using System;
using WildFarm.Core;
using WildFarm.IO;

namespace WildFarm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleWriter writter = new ConsoleWriter();
            ConsoleReader reader = new ConsoleReader();

            Engine engine = new Engine(reader, writter);

            engine.Run();
        }
    }
}
