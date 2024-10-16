
using System.Linq.Expressions;
using System.Xml.Linq;

List<int> ints2 = new List<int>(6);
Console.WriteLine("Hello!");
int element = 0;
for (int i = 0; i < 6; i++)
{
    Console.WriteLine($"Enter the element #{i+1} :");
    element = int.Parse(Console.ReadLine());
    ints2.Add(element);
}

