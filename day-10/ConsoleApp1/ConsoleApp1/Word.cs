using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Word : IPrintable
    {
        public void Print()
        {
            Console.WriteLine("Word Chap edildi");
        }
    }
}
