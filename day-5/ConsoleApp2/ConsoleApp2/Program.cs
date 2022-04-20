using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str=Console.ReadLine();
            str=str.ToLower();  
            string[] words = str.Split();
            string newword = "";
            foreach (string word in words)
            {
                newword += word[0].ToString().ToUpper() + word.Substring(1) + " ";
            }
            Console.WriteLine(newword);
           
            
           
            
          



        }
    }
}
