using System;

namespace Raiding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleReader reader = new ConsoleReader();
            ConsoleWriter writer = new ConsoleWriter();

            Engine engine = new Engine(writer, reader);

            engine.Run();

        }
    }
}
