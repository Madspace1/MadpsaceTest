using New_array_29_07;

Class1 class1 = new Class1();

class1[0] = 1;
class1[1] = 4;
class1[2] = 8;
class1[3] = 22;
class1[4] = 27;
foreach (int i in class1.MyArray)
{ Console.WriteLine(i); }


for (int i = 0; i<5; i++)
{
    Console.WriteLine($"Enter element #{i+1} of array: ");
    int elem = int.Parse(Console.ReadLine());
    class1.MyArray[i] = elem; 
}

Console.WriteLine("Enter index of array for insert: ");
int ind= int.Parse(Console.ReadLine());
Console.WriteLine("Enter your insert number: ");
int number = int.Parse(Console.ReadLine());

class1.Insert(ind, number);
foreach (int i in class1.MyArray)
{ Console.WriteLine(i); }