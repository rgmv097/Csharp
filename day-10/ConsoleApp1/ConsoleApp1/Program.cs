using System;
using ConsoleApp1.Interfaces;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        NewPlace:
            Console.WriteLine("Please choose the one");
            Console.WriteLine("1 - Excel\n2 - Word\n3 - PDF\n4 - Clear Console\n5 - Exit");
            int choose = Convert.ToInt32(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    MainPrintFile excel = new MainPrintFile(new Excel());
                    Console.WriteLine("- - - - - - -");
                    goto NewPlace;
                case 2:
                    MainPrintFile word = new MainPrintFile(new Word());
                    Console.WriteLine("- - - - - - -");
                    goto NewPlace;
                case 3:
                    MainPrintFile pdf = new MainPrintFile(new PDF());
                    Console.WriteLine("- - - - - - -");
                    goto NewPlace;
                case 4:
                    Console.Clear();
                    goto NewPlace;
                case 5:
                    break;
                default:
                    Console.WriteLine("Please choose the correct variant");
                    Console.WriteLine("- - - - - - -");
                    break;
            }

            

            
        }
    }
}
