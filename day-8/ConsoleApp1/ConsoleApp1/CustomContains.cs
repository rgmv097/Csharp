using System;

namespace ConsoleApp1
{
    static class CustomContains
    {
        public static void CustomContain(this string Word, string SearchWord)
        {
            Word = Word.ToLower();
            SearchWord = SearchWord.ToLower();
            bool result = false;
            for (int i = 0; i < Word.Length - SearchWord.Length + 1; i++)
            {
                string NewWord = Word.Substring(i, SearchWord.Length);
                if (NewWord == SearchWord) { result = true; break; }
            }
            Console.WriteLine(result);
        }
    }

}
