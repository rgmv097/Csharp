using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class PDF : MainPrintFile, IPrintable
    {
        public void Print()
        {
            Console.WriteLine("PDF chap edildi");
        }
    }
}
