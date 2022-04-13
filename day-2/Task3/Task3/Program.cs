using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.Bir string arrayinin icersinde uzunlugu 5 den boyuk olan sozleri ekrana cixardan bir alqoritm yazin.
            string[] arr = { "Chingiz", "Fexrin", "Cavid", "iki", "bir" };

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length>5)
                {
                    Console.WriteLine(arr[i]);

                }



            }




        }
    }
}
