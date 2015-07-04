using PING.Interfaces;

namespace PING
{
    class MixedOutput: IDataOutput
    {
        private readonly ConsoleOutput _consoleOutput = new ConsoleOutput();
        private readonly FileOutput _fileOutput = new FileOutput();

        public void WriteData(string data)
        {
            _consoleOutput.WriteData(data);
            _fileOutput.WriteData(data);
        }
    }
}
