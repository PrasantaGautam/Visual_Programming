// Question : Make a Flag of Nepal using asterik (*)
*
**
***
****
*****
*
**
***
****
*****

using System;

public class HelloWorld 
{
	public static void Main(string[] args) 
	{	
		for(int i=0;i<2;i++) 
		{
			for(int j=0;j<5;j++)
			{ 
				for(int k=0;k<=j;k++) 
				{	
					Console.Write("*"); 
				}
 			Console.Write("\n");
			}
		}
	}
}
