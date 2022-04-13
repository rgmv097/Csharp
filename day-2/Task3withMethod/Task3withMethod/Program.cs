using System;

namespace Task3withMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir string arrayinin icersinde uzunlugu 5 den boyuk olan sozleri ekrana cixardan bir alqoritm yazin.
            //method vasitesi ile verilmish reqemden uzun olan soz ekrana cixarilsin
            string[] arr = { "fexrin", "Chingiz", "cavid", "shahxrom", "bir","dord" };
            
            Console.WriteLine("Massivde daxil etdiyiniz reqemden uzun string ekrana verilsin:");
            int divide=Convert.ToInt32(Console.ReadLine());
            strArr(arr,divide);

        }
        public static void strArr(string[] arr,int divide)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length>divide)
                {
                    Console.WriteLine(arr[i]);

                }

            }


        }
        
    }
}
