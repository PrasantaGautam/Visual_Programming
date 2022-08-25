using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
    	// Here Console.WriteLine to write a line on a console	
      	Console.WriteLine("Enter username: ");
      	// Here Console.ReadLine to read a line from a console
      	string userName = Console.ReadLine();
      	// Here ReadLine stores the data from console on the given variable -> userName
      	Console.WriteLine("Username is: " + userName);
      	// Just above + operator is used to concatenate string 
    }
  }
}
