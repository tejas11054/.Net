using System;
    
class Program
{
    static int CountWords(string sentence)
    {
        string [] words = sentence.Split(new char[] {' ', '\t', '\n'}, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
    public static void Main(string [] args)
    {
        Console.WriteLine("Enter a sentence");
        string sentence = Console.ReadLine();
        
        int wordCount = CountWords(sentence);
        Console.WriteLine("Number of words = " + wordCount);
    }
}
