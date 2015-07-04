using System;

namespace PING
{
    class Program
    {
        private static  readonly CheckAccess _checkAccess = new CheckAccess();

        static void Main(string[] args)
        {
            var factory = new Factory();
            var result = _checkAccess.PingUrl("http://google.com");

            // If 1 - write to console
            // If 2 - write to file
            // If 3 - both
            // If Esc - exit
            while (true)
            {
                var key = Console.ReadKey();
                if (ConsoleKey.Escape == key.Key)
                {
                    return;
                }
                var outputer = factory.Create(key.Key);
                outputer.WriteData(result);
            }

        }
    }
}
