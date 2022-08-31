using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      // Break on c sharp
      for (int i = 0; i < 10; i++) 
      {
        if (i == 4) 
        {
          break;
        }
        Console.WriteLine(i);
      }    
      // Continue on c sharp
      for (int i = 0; i < 10; i++) 
      {
        if (i == 4) 
        {
          continue;
        }
        Console.WriteLine(i);
      } 
    }
  }
}
