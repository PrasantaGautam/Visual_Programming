using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        for (initialization; condition; increment/decrement;)
        {
            statement
        }
        initialization : Only execute once in begin of program
        condition : Every time on looping condition is checked if condition becomes false then the loop stops
        increment/decrement : Executed every time after the block of code executed
        */
        
        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine(i);
        }
    }
}
