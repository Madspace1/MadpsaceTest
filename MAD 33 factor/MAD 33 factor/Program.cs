/* Write a function that finds all factors of a given number.

Instructions:

Create a function List<int> FindFactors(int number) that returns a list of all factors of number.

Example: For input 12, the program should print [1, 2, 3, 4, 6, 12].Write a function that finds all factors of a given number.

Instructions:

Create a function List<int> FindFactors(int number) that returns a list of all factors of number.

Example: For input 12, the program should print [1, 2, 3, 4, 6, 12].
*/
using System.Globalization;

Console.WriteLine("Write number:");
int num = int.Parse(Console.ReadLine());

List<int> factors = FindFactors(num);

foreach (int factor in factors)
{
    Console.WriteLine(factor);
}
    

    static List<int> FindFactors(int number)
{
    List<int> factors = new List<int>();
    for (int i = 1; i <= number; i++)
    {
        if (number % i == 0)
        {
            factors.Add(i);
        }
    }
    return factors;
}
