/*Your task is to write a C# program which prints a menu 
and asks the user for input. You must use the 
switch statement. The menu and output should look 
the following:
Please select:
1) Water
2) Juice
3) Lemonade
4) Quit
2
You selected Juice.*/
using System;
class switchExercise
{
	static void Main(){
		int selectOne;
		Console.WriteLine("Please select:\n1) Water\n2) Juice\n3) Lemonade\n4) Quit");
		selectOne = Convert.ToInt32(Console.ReadLine());
		switch (selectOne)
		{
			case 1:
				Console.WriteLine("You selected Water.");
				break;
			case 2:
				Console.WriteLine("You selected Juice.");
				break;
			case 3:
				Console.WriteLine("You selected Lemonade.");
				break;
			case 4:
				Console.WriteLine("Quit!");
				break;
			default:
				Console.WriteLine("Invalid selection.");
				break;
		}
	}
}