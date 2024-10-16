
/*
 * Console.WriteLine("Enter array length");
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
*/
Console.WriteLine("Enter the array length");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Enter the number #{i + 1}");
    int a = int.Parse(Console.ReadLine());
    array[i] = a;
}

int numberOfDuplicates = 0;

Dictionary<int, HashSet<int>> map = new Dictionary<int, HashSet<int>>();
for (int i = 0; i < array.Length; i++)
{
    for (int j = i+1; j < array.Length; j++)
    {
        if (array[i] == array[j])
        {
            var currentValue = array[i];
            if (map.ContainsKey(currentValue))
            {
                map[currentValue].Add(i);
                map[currentValue].Add(j);
            }
            else
            {
                map[currentValue] = new HashSet<int>();
                map[currentValue].Add(i);    
                map[currentValue].Add(j);    
            }
        }
    }
}


foreach (var item in map)
{
    Console.WriteLine($"Value: {item.Key} were found in the next indexes:");
    HashSet<int> values = item.Value;
    foreach (var value in values)
    {
        Console.WriteLine(value);
    }
}
Console.ReadLine();