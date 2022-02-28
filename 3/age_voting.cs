/*Write a C# program which asks the user’s age and 
then prints out if the user is eligible to cast his/her 
own vote. The age limit for casting a vote is 18.*/
using System;
class ageDetector {
	static void Main(){
		int age;
		Console.WriteLine("Please input your age: ");
		age=Convert.ToInt32(Console.ReadLine());
		if(age>=18){
			Console.WriteLine("You can cast your vote!");
		}
	}
}