/*Question : 
	Print the given format on console using c-sharp : 
							******
							******
							******
							******
							******
							******

	*/
	
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        for (int i = 0; i<=5; i++)
        {
            for (int j = 0; j<=5; j++)
            {
                string str = "*";
                if (j < 5)
                {
                    Console.Write(str);
                }
                else
                {
                    Console.WriteLine(str);
                }
            }
        }
    }
}
