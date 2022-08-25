using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        while (condition)
        {
            statement
        }
        */
        
        int i = 0;
        while (i<10)
        {
            Console.WriteLine(i);
            i++;   // If i is not increment while loop is unstoppable because condition will always true
        }
    }
}
