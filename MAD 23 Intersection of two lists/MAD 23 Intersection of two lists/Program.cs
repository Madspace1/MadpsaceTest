int currentvalue = 0;
int size = 4;
int sizeList2 = 5;
List<int> list1 = new List<int>(size);
List<int> list2 = new List<int>(sizeList2);
List<int> list3 = new List<int>(size);
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Enter Element #{i + 1} in LIST #1:");
    int List1Elements = int.Parse(Console.ReadLine());
    list1.Add(List1Elements);
}

for (int i = 0; i < sizeList2; i++)
{
    Console.WriteLine($"Enter Element #{i + 1} in LIST #2:");
    int List2Elements = int.Parse(Console.ReadLine());
    list2.Add(List2Elements);
}

for (int i = 0; i < size; i++)
{
    bool unique = false;
    currentvalue = list1[i];
    for (int j = 0; j < size; j++)
    {
        if (currentvalue == list2[j])
        {
            unique = true;
        }

    }
    if (unique)
    {
        list3.Add(currentvalue);
    }

}

for (int i = 0; i < list3.Count; i++)
{
    Console.WriteLine(list3[i]);
}
