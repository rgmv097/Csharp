using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console app-da bir eded daxil olunur. Eger bu eded 7-ye bolunurse ekrana "7 ye bolunur" yazilsin.
            // Eks halda daxil olunan edede en yaxin
            // 7-ye bolunen eded ekranda yazilsin(Meselen: 17 yazilibsa ekrana  21 yox 14 cixsin, 19 yazilibsa 21 cixsin)

            
          //  22/7=3 qaliq 1 en yaxin 21
         // 23/7=3 qaliq 2 en yaxin 21
         //24/7=3 qaliq 3 en yaxin 21
         //25/7=3 qaliq 4  en yaxin 28
         //26/7=3 qaliq 5 en yaxin 28
         //27/7=3 qaliq 6 en yaxin 28
         //29/7=4

            int digit=Convert.ToInt32(Console.ReadLine());

            Division(digit);

        }
        public static void Division(int digit)
        {

            if (digit % 7 == 0)
            {
                Console.WriteLine("7 e tam bolunur");
            }
            else if (digit % 7 <= 3)
            {
                digit -= digit % 7;
                Console.WriteLine("Bu edede en yaxin 7 e bolunen eded");

                Console.WriteLine(digit);

            }
            else if (digit % 7 >= 4)
            { 
                digit = 7 - digit % 7 + digit;
                Console.WriteLine("Bu edede en yaxin 7 e bolunen eded");

                Console.WriteLine(digit);

            }
           

            

        }
    }
}
