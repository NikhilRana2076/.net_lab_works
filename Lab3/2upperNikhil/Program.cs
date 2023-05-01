using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string str = "My Name is NIKHIL and This is my Code.";

        var upperCaseLetters = str.Where(c => char.IsUpper(c));

        Console.WriteLine("Uppercase letters in the string:");
        foreach (var letter in upperCaseLetters)
        {
            Console.Write(letter + " ");
        }
    }
}

