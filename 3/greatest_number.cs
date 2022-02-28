/*Write a program which asks the user to input 
two integers and then tells which of 
the numbers is greater or if they are equal.*/
using System;
class ageDetector {
	static void Main(){
		int num1,num2;
		Console.WriteLine("Please input the first number: ");
		num1=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Please input the second number: ");
		num2=Convert.ToInt32(Console.ReadLine());		
		if(num1 == num2){
			Console.WriteLine("Numbers are equal.");
		}else if(num1>num2){
			Console.WriteLine("Number 1 is greater than number 2.");
		}else if(num1<num2){
			Console.WriteLine("Number 2 is greater than number 1.");
		}
	}
}