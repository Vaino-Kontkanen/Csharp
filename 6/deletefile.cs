/*Write a C# program which deletes all 
files with .dat suffix from the current 
directory and prints how many files were deleted.*/
using System;
using System.IO;
class directoryDelete
{
	static void Main()
	{
		string path = ".";
		string[] dirList = Directory.GetFiles(path, "*.dat");
		int tally = 0;
		if (dirList.Length > 0)
		{
			foreach (string fileName in dirList)
			{
				File.Delete(fileName);
				tally++;
			}
		}
		Console.WriteLine (tally + " file(s) deleted.");
	}
}	