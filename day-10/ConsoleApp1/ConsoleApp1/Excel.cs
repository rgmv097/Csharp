using ConsoleApp1.Interfaces;
using System;

namespace ConsoleApp1
{
    internal class Excel : IPrintable
    {
        public void Print()
        {
            Console.WriteLine("Excel chap edildi");
        }
    }
}
