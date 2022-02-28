/*Write a C# program which prints out the first provided 
command line argument. You can assume the argument is 
always provided and consists of letters and digits.*/
using System;
class cliArgument
{
	static void Main(string[] args)
	{
		Console.Write("The command line argument was: ");
		Console.WriteLine(args[0]);
	}
}