/*Your task is to declare variables and assign 
suitable values to them according to the list below:
var1 of type short
var2 of type byte 
var3 of type float
var4 of type char
var5 of type boolean
var6 of type ulong
var7 of type decimal.*/
using System;
class datatypes
{
    static void Main()
    {
        short var1= 2;
	    byte var2 = 2;
	    float var3 = 1;
	    char var4 = 'M';
	    bool var5 = true;
	    ulong var6 = 400;
	    decimal var7 = 2;
        Console.WriteLine("Var1 is of type "+ var1.GetType());
        Console.WriteLine("Var2 is of type "+ var2.GetType());
        Console.WriteLine("Var3 is of type "+ var3.GetType());
        Console.WriteLine("Var4 is of type "+ var4.GetType());
        Console.WriteLine("Var5 is of type "+ var5.GetType());
        Console.WriteLine("Var6 is of type "+ var6.GetType());
        Console.WriteLine("Var7 is of type "+ var7.GetType());
    }
}