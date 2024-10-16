/*Console.WriteLine("Enter array length");
int length = int.Parse(Console.ReadLine());

int[] array1 = new int[length];
int[] array2 = new int[length];
int i = 0;
for (i = 0; i < length; i++)
{
    Console.WriteLine($"Enter number # {i}");
    int number = int.Parse(Console.ReadLine());
    array1[i] = number;
}
for (i = 0; i < length; i++)
{
    int numberTemp = i;
    for (int j = i+1; j < length; j++)
    {
        if (array1[i] != array1[j] && i != j)
        {
            array2[i] = array1[i];
        }
    }    
}
foreach (var elements in array2)
{
    Console.WriteLine($"{elements}");
}
*/

using System.Diagnostics.Metrics;

Console.WriteLine("Enter array length");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
int[] array2 = new int[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Enter the number # {i + 1}");
    int element = int.Parse(Console.ReadLine());
    array[i] = element;
}

int counter = 0;
for (int i = 0; i < size; ++i)
{
    bool alreadyExists = false;

    int currentValue = array[i];
    for (int j = 0; j < counter; ++j)
    {
        if (array2[j] == currentValue)
        {
            alreadyExists = true;
            break;
        }
    }

    if(alreadyExists == false)
    {
        array2[counter] = currentValue;
        counter++;
    }
}
for (int i = 0; i < counter; i++)
{
    Console.WriteLine("");
    Console.WriteLine(array2[i]);
}
