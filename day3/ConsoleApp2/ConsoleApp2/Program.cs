using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 eded daxil edin. Eger o eded 50den kicikdirse o edede qeder 3-e bolunen,
            //50-100 araligindadirsa o edede qeder 5e bolunen, 100den boyukdurse o edede qeder
            //8 e bolunen ededleri ayri bir arrayin icerisine elave edib, bolunen butun ededleri ekrana cixardan bir alqoritm
            int divide = Convert.ToInt32(Console.ReadLine());
            Digit(divide);

        }
        public static void Digit(int divide)
        {
            if (divide<=50)
            {
                Console.WriteLine(divide + " Ededine qeder 3 e bolunen edeler");

                for (int i = 1; i < divide; i++)
                {

                    if (i%3==0)
                    {

                       
                        Console.WriteLine(i);

                    }

                }


            }
            else if (divide>=50 && divide<=100)
            {
                Console.WriteLine(divide+" Ededine qeder 5 e bolunen edeler");
                
                for (int i = 1; i <= divide; i++)
                {

                    if (i%5==0)
                    {

                        Console.WriteLine(i);

                    }

                }


            }
            else if (divide > 100)
            {
                Console.WriteLine(divide + " Ededine qeder 8 e bolunen edeler");

                for (int i = 1; i < divide; i++)
                {
                    if (i%8==0)
                    {
                       

                        Console.WriteLine(i);
                    }

                }


            }




        }
    }
}
