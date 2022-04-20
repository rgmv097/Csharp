using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str=Console.ReadLine();
            string a= str.Substring(0, 1).ToUpper();
            str = str.Substring(1);
            Console.WriteLine(str);



        }
    }
}
