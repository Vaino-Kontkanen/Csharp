/*You are provided with a List of type string having the following names:
Torvalds, Musk, Gates, Buffet, Dorsey.
Modify the list so that the items are:
Jobs, Musk, McAfee, Buffet, Wozniak.*/
using System;
using System.Collections.Generic;
using System.Linq;
class program
{
    static void Main()
    {
        List<string> Names = new List<string> {"Torvalds","Musk","Gates","Buffet","Dorsey"};
		Names.Remove("Torvalds");
        Names.Remove("Gates");
		Names.Remove("Dorsey");
		Names.Add("Jobs");
		Names.Add("Wozniak");
		Names.Add("McAfee");
		var order = new List<int>{2, 0, 4, 1, 3};
		var names = order.Select(i => Names[i]).ToList();
        foreach(string name in names)
        {
            Console.WriteLine(name);
        }
    }
}