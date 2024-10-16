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
    int currentElementValue = array[i];
    bool hasEquals = false;

    for (int j = 0; j < size; ++j)
    {
        if (i == j)
        {
            continue;
        }
        if (currentElementValue == array[j])
        {
            array2[i] = currentElementValue;
            hasEquals = true;
        }
    }

    if (!hasEquals)
    {
        array2[i] = currentElementValue;
        Console.WriteLine(array2[i]);
    }
}


/*
for (int i = 0; i < size; i++)
{
    for (int j = i + 1; j < size; j++)
    {
        counter++;
        if (array[i] != array[j])
        {
            uniqueElements[i] = array[i];
            
        }
    }
}

for (int i = 0; i < counter; i++)
{
    if (uniqueElements[i] != 0)
    {
        Console.WriteLine($"Your unique elements is: {uniqueElements[i]} ");
    }
   
}
Console.ReadLine();
*/



