using System.ComponentModel.Design;
using System.Diagnostics.Metrics;

Console.WriteLine("Enter array length: ");
int size = int.Parse(Console.ReadLine());

int[] array = new int[size];
bool polindrom = true;

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Enter the number # {i+1}");
    int number = int.Parse(Console.ReadLine());
    array[i] = number;
}

for (int i = 0; i < array.Length/2; i++)
{
    if (array[i] != array[array.Length - 1 - i])
    {
        polindrom = false;
    }
}

if (!polindrom)
{
    Console.WriteLine("Your array is NOT palindrome");

}
else
{
    Console.WriteLine("Your array is a palindrome");
}