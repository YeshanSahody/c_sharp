namespace Trainings
{
    class Program
    {
        static void Main()
        {
            //How to find if the given string is a palindrome or not?
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            if (IsPalindrome(input))
            {
                Console.WriteLine($"{input} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{input} is not a palindrome.");
            }

            //How to reverse the order of words in a given string?
            Console.Write("Original string: ");
            string inputText = Console.ReadLine();

            string reversedString = ReverseWords(inputText);

            Console.WriteLine($"Reversed string: {reversedString}");
        }

        static bool IsPalindrome(string str)
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

        static string ReverseWords(string input)
        {
            string[] words = input.Split(' ');

            Array.Reverse(words);

            string reversedString = string.Join(" ", words);

            return reversedString;
        }
    }
}