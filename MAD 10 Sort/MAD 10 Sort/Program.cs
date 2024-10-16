Console.WriteLine("Enter array length");
int y = int.Parse(Console.ReadLine());

int[] array = new int[y];

for (y = 0; y < array.Length; y++)
{
    Console.WriteLine($"Enter the number #{y + 1}");
    string a = Console.ReadLine();
    array[y] = int.Parse(a);
}

for (y = 0; y < array.Length; y++)
{
    for (int j = 0; j < array.Length - 1; j++)
    {
        if (array[j] > array[j + 1])
        {
            var temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
        }
    }
}


for (y = 0; y < array.Length - 1; y++)
{
    for (int j = y + 1; j < array.Length; j++)
    {
        if (array[y] > array[j])
        {
            var temp = array[j];
            array[j] = array[y];
            array[y] = temp;
        }
    }
}

for (y = 0; y < array.Length; y++)
{
    Console.WriteLine(array[y]);
}

Console.ReadLine();
