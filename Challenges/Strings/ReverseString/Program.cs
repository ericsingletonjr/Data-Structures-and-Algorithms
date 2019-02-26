using System;
using System.Text;

namespace ReverseString
{
    class Program
    {
        //Problem Domain:
        //Different ways to reverse a string
        static void Main(string[] args)
        {
            string word = "Hello World!";
            Console.WriteLine(ReverseString1(word));
            Console.WriteLine("=========");
            Console.WriteLine(ReverseString2(word));
            Console.WriteLine("=========");
            Console.WriteLine(ReverseString3(word));
            Console.WriteLine("=========");
            Console.WriteLine(ReverseString4(word));
            Console.WriteLine("=========");
        }

        /// <summary>
        /// This method uses the built in functionality of .Reverse
        /// and .ToCharArray
        /// </summary>
        /// <param name="word">string parameter</param>
        /// <returns>string</returns>
        public static string ReverseString1(string word)
        {
            char[] reverse = word.ToCharArray();
            Array.Reverse(reverse);
            return new string(reverse);
        }
        /// <summary>
        /// This method uses a foreach to iterate through a string
        /// and insert each character into the stringbuilder
        /// </summary>
        /// <param name="word">string parameter</param>
        /// <returns>string</returns>
        public static string ReverseString2(string word)
        {
            StringBuilder sb = new StringBuilder();
            foreach(var letter in word)
            {
                sb.Insert(0, letter);
            }
            return sb.ToString();
        }
        /// <summary>
        /// This method iterates through a word backwards and 
        /// appends each character to a stringbuilder
        /// </summary>
        /// <param name="word">string parameter</param>
        /// <returns>string</returns>
        public static string ReverseString3(string word)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = word.Length - 1; i > -1; i--)
            {
                sb.Append(word[i]);
            }
            return sb.ToString();
        }
        /// <summary>
        /// This method uses recursion and .Substring to
        /// iterate through a given word until it reaches a single char
        /// and proceeds to return through the stack giving the string
        /// in reverse order
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static string ReverseString4(string word)
        {
            if (word.Length <= 1) return word;
            return ReverseString4(word.Substring(1)) + word[0];
        }

    }
}
