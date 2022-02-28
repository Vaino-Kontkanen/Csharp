/*Your task is to write a C# program which 
asks the user for a file name and content. 
Then the program creates the file 
with the user provided content.*/
using System;
using System.IO;
class writefile
{
	static void Main()
	{
		string file, content;
		Console.Write("Filename to create: ");
		file = Console.ReadLine();
		Console.WriteLine("Provide the content for " + file + ":");
		content = Console.ReadLine();
		using (StreamWriter sw = new StreamWriter(file))
		{
			sw.Write(content);
		}
	}
}