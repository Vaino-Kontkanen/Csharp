/*Your task is to declare the variables listed below and 
assign any acceptable values to them.
var1 = 8-bit signed integer
var2 = 64-bit signed integer
var3 = 16-bit unsigned integer
var4 = 64-bit double-precision floating point type*/
using System;
class Conversion
{
    static void Main()
    {
        sbyte var1 = 127;
		long var2 = 12;
		ushort var3 = 12;
		double var4 = 1.2;
        if(var1.GetType()==typeof(SByte))
        {
            Console.WriteLine("var1 type ok.");
        }
        if(var2.GetType()==typeof(Int64))
        {
            Console.WriteLine("var2 type ok.");
        }
        if(var3.GetType()==typeof(UInt16))
        {
            Console.WriteLine("var3 type ok.");
        }
        if(var4.GetType()==typeof(Double))
        {
            Console.WriteLine("var4 type ok.");
        }        
    }
}