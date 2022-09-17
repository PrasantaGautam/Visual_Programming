// Question : Celcius input from user and out Fahreinheit of given celcius

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Celsius : ");
        // Input from user
        string inpCelsius = Console.ReadLine();
        // Converting string to double
        double celsius = Convert.ToDouble(inpCelsius);
        // Calculating fahrenheit by it's formula
        double fahrenheit = (celsius * 9) / 5 + 32;
        // Printing calculated fahrenheit in console
        Console.WriteLine("In Fahrenheit : " + fahrenheit);
    }
}
