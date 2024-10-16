Console.WriteLine("Enter array length");
int y = int.Parse(Console.ReadLine());

int[] array = new int[y];


for ( y = 0; y < array.Length; y++)
{
    Console.WriteLine($"Enter the number #{y + 1}");
    string a = Console.ReadLine();
    array[y] = int.Parse(a);
}
Console.WriteLine("What number do you want to find? :");
int find = int.Parse(Console.ReadLine());
bool flag = false;
int result = 0;
for ( y = 0; y < array.Length; y++)
{
    if (array[y] == find)
    {
        flag = true;
        result = result + 1;
        
    }
}


for ( y = 0; y < array.Length; y++)
{
    Console.WriteLine($"Element # {y + 1}: {array[y]}");
}

if (flag == true)
{
    Console.WriteLine($"{result} times this number appears in the array ");
}
else
{
    Console.WriteLine($"The number {find} is not found");
}

Console.ReadLine();
