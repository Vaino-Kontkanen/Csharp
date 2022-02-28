/*Create a program which opens an existing file, 
prompts the user for content and appends 
the provided content to the file.*/
using System;
using System.IO;
class appendfile
{
	static void Main()
	{
		string file, content;
		Console.Write("Append to file: ");
		file = Console.ReadLine();
		Console.WriteLine("Provide the content for " + file + ":");
		content = Console.ReadLine();
		using (StreamWriter sw = new StreamWriter(file, true))
		{
			sw.WriteLine(content);
		}
	}
}