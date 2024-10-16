using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;
List<int> list1 = new List<int>();
List<int> listEven = new List<int>();
List<int> listOdd = new List<int>();
int number = 0;
int currentvalue = 0;

//ENTER
for (int i = 0; i < 6; i++)
{
    Console.WriteLine($"Enter the number #{i+1}");
    number = int.Parse( Console.ReadLine() );
    list1.Add(number);
}
for (int i = 0; i < 6; i++)
{
    currentvalue = list1[i];
        if (currentvalue % 2 == 0)
        {
            listEven.Add(currentvalue);
        }
        else
        {
            listOdd.Add(currentvalue);
        }
}
// PRINT
Console.WriteLine("===================");
Console.WriteLine("Even: ");
for (int i = 0; i < listEven.Count; i++)
{
    Console.WriteLine($"{listEven[i]}");
}
Console.WriteLine("");
Console.WriteLine("Odd: ");
for (int i = 0; i < listOdd.Count; i++)
{
    Console.WriteLine(listOdd[i]);
}