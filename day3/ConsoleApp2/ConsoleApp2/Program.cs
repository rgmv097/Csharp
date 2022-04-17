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
            int count = 0;
            for (int i = 0; i < divide; i++)
            {
                if (divide < 50 && i % 3 == 0)
                {
                    count++;

                }
                else if (divide > 50 && divide < 100 && i % 5 == 0)
                {
                    count++;

                }
                else if (divide > 100 && i % 8 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Masivin element sayi:" + count + "\n");
            int[] arr = new int[count];
            int k = 0;
            for (int i = 0; i < divide; i++)
            {

                if (i % 3 == 0 && divide < 50)
                {
                    for (int j = 0; j < arr.Length; j++)
                    {
                        arr[j] = i;
                        arr[k] = arr[j];
                    
                  }
                    Console.WriteLine(arr[k]);
                }

                else if (divide > 50 && divide < 100 && i % 5 == 0)
                {

                    for (int j = 0; j < arr.Length; j++)
                    {
                        arr[j] = i;
                        arr[k] = arr[j];

                    }
                    Console.WriteLine(arr[k]);

                }
                else if (divide > 100 && i % 8 == 0)
                {

                    for (int j = 0; j < arr.Length; j++)
                    {
                        arr[j] = i;
                        arr[k] = arr[j];

                    }
                    Console.WriteLine(arr[k]);

                }
            }
        }
    }
}
