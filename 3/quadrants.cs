/*Write a program which prompts the user for a point in x-y 
coordinate system and determines in which quardant the coordinate 
point is located or notifies the user if the point lies on origin.
*/
using System;
class quadrants{
	static void Main(){
		int cord1, cord2;
		Console.WriteLine("Find the quadrant for a point in x-y axis:");
		Console.Write("X coordinate: ");
		cord1=Convert.ToInt32(Console.ReadLine());
		Console.Write("Y coordinate: ");
		cord2=Convert.ToInt32(Console.ReadLine());	
		if( cord1 > 0 && cord2 > 0){
	  		Console.WriteLine("The coordinate point ({0},{1}) is in the First quandrant.",cord1,cord2);
		}else if( cord1 < 0 && cord2 > 0){
	  		Console.WriteLine("The coordinate point ({0},{1}) is in the Second quandrant.",cord1,cord2);
		}else if( cord1 < 0 && cord2 < 0){
	  		Console.WriteLine("The coordinate point ({0},{1}) is in the Third quandrant.",cord1,cord2);
		}else if( cord1 > 0 && cord2 < 0){
	  		Console.WriteLine("The coordinate point ({0},{1}) is in the Fourth quandrant.",cord1,cord2);
		}else if( cord1 == 0 && cord2 == 0){
	  		Console.WriteLine("The coordinate point ({0},{1}) is at the origin.",cord1,cord2);
		}
	}
}