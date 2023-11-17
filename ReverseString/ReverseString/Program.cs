using ReverseString;
using System;
using System.Text;

class program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your text: ");
        string OriginalText = Console.ReadLine();

        string ReversedText = AnotherClass.Rstring(OriginalText);

        Console.WriteLine($"The reverse text is {ReversedText}");
    }
}