using System;

public class Program
{
    public static void Main()
    {
        string input = "Hello, world!";
        string reversedString = ReverseString(input);
        Console.WriteLine("Reversed string: " + reversedString);
    }

    public static string ReverseString(string str)
    {
        if (str == null)
        {
            throw new ArgumentException("Input string cannot be null");
        }

        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}