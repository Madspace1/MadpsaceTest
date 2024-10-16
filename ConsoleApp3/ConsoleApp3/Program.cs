using System.Diagnostics.Metrics;

Console.WriteLine("Enter array length");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
int[] array2 = new int[size];
int k = 0;
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Enter the number # {i + 1}");
    int element = int.Parse(Console.ReadLine());
    array[i] = element;
}

for (int i = 0; i < size; ++i)
{
    bool unique = true;
    int currentElementValue = array[i];
    

    for (int j = 0; j < size; ++j)
    {
        if ( i == j)
        {
            continue;
        }
   
        if (currentElementValue == array[j])
        {
            
            unique = false;
            break;
        }
       
    }
    if (unique)
    {
        array2[k] = currentElementValue;
        k++;
    }

}
for (int z = 0; z < k; ++z)
{
    {
        Console.WriteLine("");
        Console.WriteLine(array2[z]);
    }
}
