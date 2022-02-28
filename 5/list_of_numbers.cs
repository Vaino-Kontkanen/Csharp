/*Write a program which prompts the user to 
provide integer numbers until a negative 
number is given. The provided numbers must 
be added to a List of type int named numbers. 

Note! Only provide the functionality for List 
declaration, user input (use pre-defined 
variable int input) and adding elements to the list.*/
using System;
using System.Collections.Generic;

class program
{
    static void Main()
    {
        int input;
        List<int> numbers = new List<int>();
        do
        {
            Console.Write("Input a number:");
            input = Convert.ToInt32(Console.ReadLine());
			if(input >=0)
			{
            	numbers.Add(input);
			}
        } while (input >= 0);
        Console.Write("Your input: ");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}
