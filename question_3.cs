/*
Question :
Make a Division evaluation program where user can find user division by inserting their marks
*/
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your percentage : ");
        string inpPercentage = Console.ReadLine();
        int percentage = Convert.ToInt32(inpPercentage);
        
        if (percentage >= 75)
        {
            Console.WriteLine("Distinction");
        }
        else if (percentage < 75 && percentage >= 60)
        {
            Console.WriteLine("First Division");
        }
        else if (percentage < 60 && percentage >= 50)
        {
            Console.WriteLine("Second Division");
        }
        else if (percentage < 50 && percentage >= 40)
        {
            Console.WriteLine("Third Division");
        }
        else if (percentage < 40 && percentage >= 0)
        {
            Console.WriteLine("Low Level");
        }
        else
        {
            Console.WriteLine("Invalid Percentage input !!!");
        }
    }
}
