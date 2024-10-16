

int[] array = new int[3];
array[0] = 1;
array[1] = 3;
array[2] = 2;

array[0] = 5;



for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Enther the number #{i + 1}");
    string a = Console.ReadLine();
    array[i] = int.Parse(a);
}
int b = array[1];
array[1] = array[2];
array[2] = b;

bool flag = false;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == 5)
    {
        flag = true;
        break;
    }
}

if (flag == true)
{
    Console.WriteLine("OK");
}
else
{
    Console.WriteLine("NOT FOUND");
}

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Element # {i+1}: {array[i]}");
}

Console.ReadLine();
