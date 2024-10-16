Console.Write("Enter array length:  ");
int length = int.Parse(Console.ReadLine());

int[] array = new int[length];
for (int i = 0; i < length; i++)
{
    Console.Write($"Enter the number #{i + 1}:  ");
    int element = int.Parse(Console.ReadLine());
    array[i] = element;
}
Console.Write("Enter the value of target sum:  ");
int sum = int.Parse(Console.ReadLine());

for (int i = 0; i < length; ++i)
{
    for (int j = 0; j < length; ++j)
    {
        if (i == j)
        {
            continue;
        }
        if (sum == array[i] + array[j])
        {
            Console.WriteLine($"Element # {i + 1} + Element # {j + 1} = your {sum} ");
        }
    }
}

   
