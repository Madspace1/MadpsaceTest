using System.ComponentModel;
using System.Drawing;
int currentvalue = 0;
int size = 5;
List<int> list1 = new List<int>(size);
List<int> list2 = new List<int>(size);
List<int> list3 = new List<int>(size);
int count = 0;
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Enter Element #{i + 1} in LIST #1:");
    int List1Elements = int.Parse(Console.ReadLine());
    list1.Add(List1Elements);
}

for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Enter Element #{i + 1} in LIST #2:");
    int List2Elements = int.Parse(Console.ReadLine());
    list2.Add(List2Elements);
}

for (int i = 0; i < size; i++)
{
    bool unique = true;
    currentvalue = list1[i];
    for (int j = 0; j < size; j++)
    {   
        if (currentvalue == list2[j])
        {
            unique = false;
        }

    }
    if (unique)
    {
        list3.Add(currentvalue);
        count++;
    }

}
//try

for (int i = 0; i < size; i++)
{
    bool unique = true;
    currentvalue = list2[i];
    for (int j = 0; j < size; j++)
    {
        if (currentvalue == list1[j])
        {
            unique = false;
        }

    }
    if (unique)
    {
        list3.Add(currentvalue);
        count++;
    }

}

for (int i = 0; i < count; i++)
{
    Console.WriteLine(list3[i]);
}

