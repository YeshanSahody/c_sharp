using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainings
{
    internal class exercise
    {
        public static bool IsPalindrome(string str)
        {
            str = str.Replace(" ", "").ToLower();

            int length = str.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (str[i] != str[length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static string ReverseWords(string input)
        {
            string[] words = input.Split(' ');

            Array.Reverse(words);

            string reversedString = string.Join(" ", words);

            return reversedString;
        }
    }
}
