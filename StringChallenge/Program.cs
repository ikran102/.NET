using System;

class Program
{
    static void Main()
    {
        // Input string
        string s = "The quick brown fox jumps over the lazy dog";

        // Print the reversed words and their character count
        Console.WriteLine("Reversed words and their character counts:");
        ReverseAndCountWords(s);
    }

    static void ReverseAndCountWords(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Input string is empty or null.");
            return;
        }

        // Split the input string into words
        string[] words = input.Split(' ');

        foreach (var word in words)
        {
            // Reverse each word
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            string reversedWord = new string(charArray);

            // Print the reversed word and its character count
            Console.WriteLine($"Reversed Word: {reversedWord}, Length: {reversedWord.Length}");
        }
    }
}

