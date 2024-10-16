Console.WriteLine("Enter array length");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
int[] array2 = new int[size];
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
        array2[i] = currentElementValue;
    }

}
for (int i = 0; i < size; ++i)
{
    if (array2[i] == 0)
    { 
        continue; 
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine(array2[i]);
    }
}
