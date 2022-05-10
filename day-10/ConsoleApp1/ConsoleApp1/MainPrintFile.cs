using ConsoleApp1.Interfaces;

namespace ConsoleApp1
{
    internal class MainPrintFile
    {
        public MainPrintFile(IPrintable file)
        {
            file.Print();
        }

    }
}
