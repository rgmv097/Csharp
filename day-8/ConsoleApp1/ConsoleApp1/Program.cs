using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter word");
            string word = Console.ReadLine();
            Console.WriteLine("Enter of search string or char");
            string SearchWord = Console.ReadLine();
            if (word.Length >SearchWord.Length) { 
            word.CustomContain(SearchWord);
            }
            else { Console.WriteLine("Axtarilan sozun uznluqu uzundur"); }


        }
      

    }
}
