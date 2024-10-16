using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;
List<int> list1 = new List<int>();
List<int> list2 = new List<int>();
List<int> list3 = new List<int>();
var element="";
int currentvalue = 0;

//ENTER
    for (int i = 0; element != ("stop"); i++)
    {
      
            Console.WriteLine($"Enter the number #{i + 1} in List1");
            element = Console.ReadLine();

            if (element == ("stop"))
            {
                Console.WriteLine("============");
                break;
            }
            else
            {
                int number = int.Parse(element);
                list1.Add(number);
            }
    }

element = "";
for (int i = 0; element != ("stop"); i++)
{

    Console.WriteLine($"Enter the number #{i + 1} in List2");
    element = Console.ReadLine();

    if (element == ("stop"))
    {
        Console.WriteLine("============");
        break;
    }
    else
    {
        int number = int.Parse(element);
        list2.Add(number);
    }
}

//ACTION
for (int i = 0; i < list1.Count; i++)
{
    currentvalue = list1[i];
    bool alreadyExists = false;
    if (list3.Contains(currentvalue))
    {
        alreadyExists = true;
        continue;
    }
    if (alreadyExists == false)
    {
        list3.Add(list1[i]);
    }
}
for (int i = 0; i < list2.Count; i++)
{
    currentvalue = list2[i];
    bool alreadyExists = false;
        if (list3.Contains(currentvalue))
    {
            alreadyExists = true;
        continue;
        }
        if (alreadyExists == false)
        {
            list3.Add(list2[i]);
        }
}

//PRINT
for (int i = 0; i < list3.Count; i++)
{
    Console.WriteLine(list3[i]);
}