using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // Note if you enter number other than 1 in this program else { } is going to run
        Console.WriteLine("Enter a day from list -> [1,2,3,4,5] ");
        string day = Console.ReadLine();
        // Here if the if-condition is true then if { } will execute
        if (day == "1")
        {
            Console.WriteLine("Day is one ");
        }
        // if the if-condition is false then else if-condition will be checked
        else if (day == "2")
        {
            Console.WriteLine("Day is two");
        }
        // if upper else if is also false then another else if will checked
        else if (day == "3")
        {
            Console.WriteLine("Day is three");
        }
        else if (day == "4")
        {
            Console.WriteLine("Day is four");
        }
        else if (day == "5")
        {
            Console.WriteLine("Day is five");
        }
        // If none of the above condition arte going to be true then else { } will execute 
        else 
        {
            Console.WriteLine("Day is not on list");
        }
    }
}
