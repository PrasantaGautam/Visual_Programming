// Question : Reverse a string inputed from user using Array of char

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter string : ");
        // For getting string as input from user
        string inputString = Console.ReadLine();
        // On character Array we can easily reverse index
        // Converting string to character Array 
        char [] inputToChar = inputString.ToCharArray();
        // Making empty string for appending reversed string 
        string rvsInput = string.Empty;
        // inputToChar.Length - 1 subtract exact length by one
        // We need subtract value because index starts from 0 but here length calculation starts from 1
        for (int i = inputToChar.Length - 1; i > -1; i--)
        {
            rvsInput += inputToChar[i];
        }
        Console.WriteLine("Reverse of your string is : " + rvsInput);
    }
}
