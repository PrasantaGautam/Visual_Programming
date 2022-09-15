// Question : Reverse a string inputed from user by normal method


using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a string  : ");
        // Input from user
        string input = Console.ReadLine();
        
        for (int i = input.Length - 1; i > -1; i--)
        // Using indexing of string 
        Console.Write(input[i]);
    }
}
