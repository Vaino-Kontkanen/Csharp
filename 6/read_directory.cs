/*Create a program which reads the files in the 
current directory and prints them out one file name per line.*/
using System;
using System.IO;
class ReadDir
{
	static void Main()
	{
		string path = ".";
		string[] dirList = Directory.GetFiles(path, "*.*");
		if (dirList.Length > 0)
		{
			foreach (string fileName in dirList)
			{
				Console.WriteLine(fileName);
			}
		}
	}
}							