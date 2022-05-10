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
            bool res = int.TryParse(Console.ReadLine(), out int select);
            if (res)
            {
                switch (select)
                {
                    case 1:
                        Console.WriteLine("- - - - - - -");
                        MainPrintFile excel = new MainPrintFile(new Excel());
                        Console.WriteLine("- - - - - - -");
                        goto NewPlace;
                    case 2:
                        Console.WriteLine("- - - - - - -");
                        MainPrintFile word = new MainPrintFile(new Word());
                        Console.WriteLine("- - - - - - -");
                        goto NewPlace;
                    case 3:
                        Console.WriteLine("- - - - - - -");
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
                        goto NewPlace;
                }
            }
            else { Console.WriteLine("PLS select correct variant\n- - - - - - -"); goto NewPlace; }
        }
    }
}
