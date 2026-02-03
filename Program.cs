//Unit 2: Call the methods of the .NET class library
/*This code simulates a dice roll using the Random.Next() 
method to generate a number, 
and the Console.WriteLine() method to display the value.*/
//Overloading methods
using System.Numerics;

Random dice = new Random();
int roll1  = dice.Next();
int roll2  = dice.Next(101);
int roll3  = dice.Next(50, 101);

Console.WriteLine(roll1);
Console.WriteLine(roll2);
Console.WriteLine(roll3);

//Using the Math class

int firstValue = 500;
int secondValue = 600;
int largerValue;
largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine(largerValue);
