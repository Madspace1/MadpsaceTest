Console.Write("Enter array length:  ");
int length = int.Parse(Console.ReadLine());
int i = 0;
int[] array = new int[length];
for (i = 0; i < length; i++)
{
    Console.Write($"Enter the number #{i + 1}:  ");
    int element = int.Parse(Console.ReadLine());
    array[i] = element;
}

foreach (int element in array)
{
    Console.WriteLine(element);
}
Console.WriteLine("================================");
for (i = 0; i < length / 2; ++i)
{
    int temp = array[i];
    array[i] = array[array.Length - 1 - i];
    array[array.Length - 1 - i] = temp;
}

foreach (int element in array)
{ 
    Console.WriteLine(element);
}
