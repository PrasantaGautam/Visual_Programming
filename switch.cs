using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a day from list -> [1,2,3,4,5,6,7] ");
        // Taking input
        string strDay = Console.ReadLine();
        // Here we string input is converted to int
        int day = Convert.ToInt32(strDay);
        
        switch (day)
        {
            // If the case matches the code inside of case is going to execute 
            // Note : break is used for break the switch if the break is removed all the cases after condition is true 
            case 1:
                Console.WriteLine("Sunday");
                break;
            case 2:
                Console.WriteLine("Monday");
                break;
            case 3:
                Console.WriteLine("Tuesday");
                break;
            case 4:
                Console.WriteLine("Wednesday");
                break;
            case 5:
                Console.WriteLine("Thursday");
                break;
            case 6:
                Console.WriteLine("Friday");
                break;
            case 7:
                Console.WriteLine("Saturday");
                break;
            // If none of the cases match default section will be execute
            default:
                Console.WriteLine("Envalid input !!!");
                break;
        }

    }
}
