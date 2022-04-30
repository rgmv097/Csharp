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
            word.CustomContain(SearchWord);

        }
      

    }
}
