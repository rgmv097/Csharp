using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Excel : MainPrintFile, IPrintable
    {
        public void Print()
        {
            Console.WriteLine("Excel chap edildi");
        }
    }
}
