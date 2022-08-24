using System;

namespace HelloArea
{
  class Program
  {
    static void Main(string[] args)
    {
      int myInt = 10;
      double myDouble = 5.25;
      bool myBool = true;
      //Here we convert the type of data to another dataType
      //Console.WriteLine() used to show the output after converting data to another type
      
      Console.WriteLine(Convert.ToString(myInt));
      Console.WriteLine(Convert.ToDouble(myInt));
      Console.WriteLine(Convert.ToInt32(myDouble));
      Console.WriteLine(Convert.ToString(myBool));
      }
  }
}
