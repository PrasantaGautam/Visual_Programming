using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // Note if you enter number other than 1 in this program else { } is going to run
        Console.WriteLine("Enter a day in integer : ");
        string day = Console.ReadLine();
        // Here if if-condition is true if { } is going to run
        if (day == "1")
        {
            Console.WriteLine("Day is one ");
        }
        // if if-condition is false else { } is going to run
        else 
        {	
            Console.WriteLine("Day is not one");
        }
    }
}
