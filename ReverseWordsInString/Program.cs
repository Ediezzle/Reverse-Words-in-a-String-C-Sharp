using System;

namespace ReverseWordsInString
{
    class Program
    {
        public static string ReverseWordsInMyString(String str)
        {
            /* The split() method of String class splits
             * a string in several strings based on the
             * delimiter passed as an argument to it
             */
            string[] words = str.Split(" ");
            Array.Reverse(words);
            //return words;
            string arrayString = "";
            for (int i = 0; i < words.Length; i++)
                arrayString += words[i] + " ";
            return arrayString + ".";
        }
        static void Main(string[] args)
        {
            string st = "I am happy";
            string str = ReverseWordsInMyString(st);
            Console.Write(str);
            
        }
    }
}
