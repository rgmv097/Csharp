using System;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        NewPlace:
            Console.WriteLine("Please choose the one");
            Console.WriteLine("1 - Excel\n2 - Word\n3 - PDF\n4 - Clear Console\n5 - Exit");
            byte choose = Convert.ToByte(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    Print(new Excel());
                    Console.WriteLine("- - - - - - -");
                    goto NewPlace;
                case 2:
                    Print(new Word());
                    Console.WriteLine("- - - - - - -");
                    goto NewPlace;
                case 3:
                    Print(new PDF());
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
                    goto NewPlace;
            }
        }
        public static void Print(MainPrintFile print)
        {
            print.Print();
        }
    }
}
