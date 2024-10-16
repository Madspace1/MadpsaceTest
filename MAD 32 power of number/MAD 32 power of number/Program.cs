/*
Write a function that calculates the power of a number.

Instructions:

Create a function double Power(double baseNumber, int exponent) that returns the result of raising baseNumber to the power of exponent.

Example: For input 2 and 3, the program should print 8.
*/

using System.Numerics;

Console.WriteLine("Enter base number:");
double baseNumb = double.Parse(Console.ReadLine());

Console.WriteLine("Enter exponent number:");
int exponentNumb = int.Parse(Console.ReadLine());

double Poweeeer = Power(baseNumb, exponentNumb);
Console.WriteLine(Poweeeer);


double Power(double baseNumber, int exponent)
{
    double powerOf = baseNumb;
    for (int i = 0; i <exponent -1; i++)
    {
        powerOf = powerOf * baseNumber;
    }
    return powerOf;
}