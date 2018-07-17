using System;
using System.Text.RegularExpressions;
using RepeatedWords.Classes;

namespace RepeatedWords
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Result is "a"
            string phrase1 = "Once upon a time, there was a brave princess who...";
            //Result is "summer"
            string phrase2 = "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, " +
                             "and I didn’t know what I was doing in New York...";
            //Result is "no duplicates"
            string phrase3 = "I have no duplicates, so that is cool...";

            Console.WriteLine(RepeatedWord(phrase1));
            Console.WriteLine(RepeatedWord(phrase2));
            Console.WriteLine(RepeatedWord(phrase3));
        }
        /// <summary>
        /// Method that takes in a string that is then sanitized of punctuation
        /// and then uses a HashSet to compare if a word is duplicated or not.
        /// The first instance of a duplicated word it will return that duplicated
        /// word
        /// </summary>
        /// <param name="phrase">length string</param>
        /// <returns>Either a duplicated word or no duplicates</returns>
        public static string RepeatedWord(string phrase)
        {
            HashSet hs = new HashSet();
            Regex rgx = new Regex(@"[,.!?]+");

            phrase = rgx.Replace(phrase, "");
            string[] arr = phrase.ToLower().Split(" ");

            for(int i = 0; i < arr.Length; i++)
            {
                try
                {
                    hs.Add(arr[i], 0);
                }
                catch
                {
                    return arr[i];
                }
            }
            return "no duplicates";
        }
    }
}
