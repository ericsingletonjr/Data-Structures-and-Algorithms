using System;
using System.Collections.Generic;
using System.Text;

namespace CompressString
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = CompressStringOne("aaabbc");
            Console.WriteLine(result);
        }

        public static string CompressStringOne(string value)
        {
            Dictionary<char, int> compress = new Dictionary<char, int>();
            StringBuilder sb = new StringBuilder();
            foreach (var letter in value)
            {
                if (!compress.ContainsKey(letter))
                {
                    compress.Add(letter, 1);
                }
                else
                {
                    compress[letter] += 1;
                }
            }
            foreach (var key in compress.Keys)
            {
                sb.Append($"{key}{compress[key]}");
            }
            return sb.ToString();
        }
    }
}
