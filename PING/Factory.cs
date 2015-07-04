using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PING.Interfaces;

namespace PING
{
    class Factory
    {
        public IDataOutput Create(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.D1:
                    return new ConsoleOutput();
                case ConsoleKey.D2:
                    return new FileOutput();
                case ConsoleKey.D3:
                    return new MixedOutput();
                default:
                    return new ConsoleOutput();
            }
        }
    }
}
