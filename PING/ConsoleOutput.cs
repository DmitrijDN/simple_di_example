using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PING.Interfaces;

namespace PING
{
    class ConsoleOutput: IDataOutput
    {
        public void WriteData(string data)
        {
            Console.WriteLine(data);
            Console.ReadLine();
        }
    }
}
