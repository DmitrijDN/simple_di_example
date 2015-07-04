using System;
using System.IO;
using PING.Interfaces;

namespace PING
{
    class FileOutput: IDataOutput
    {
        public void WriteData(string data)
        {
            // Write to file action

            Console.WriteLine();
            string curFile = @"c:\temp\test.txt";
            Console.WriteLine(File.Exists(curFile) ? "File exists." : "File does not exist.");
            Console.ReadKey();
        }
    }
}
