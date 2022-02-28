/*Your task is to write a program, which prompts the user 
to provide name of a fruit and then prints 
“Your favourite fruit is name of the fruit”.*/
using System;
class favfruit 
{         
	static void Main(string[] args)
	{
		string fruit;
		Console.Write("What is your favourite fruit? ");
		fruit=Console.ReadLine();
		Console.WriteLine("Your favourite fruit is " + fruit);
    }
}