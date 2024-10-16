int size = 5;
List<int> MyFirstList = new List<int>(size);

for (int i = 0; i < MyFirstList.Count; i++)
{
    Console.WriteLine($"Enter the element #{i+1}");
    int element = int.Parse(Console.ReadLine());
    MyFirstList.Add(element);
}

for (int i = 0; i < MyFirstList.Count - 1; i++)
{
    for (int j = i + 1; j < MyFirstList.Count; j++)
    {
        if (MyFirstList[i] > MyFirstList[j])
        {
            var temp = MyFirstList[j];
            MyFirstList[j] = MyFirstList[i];
            MyFirstList[i] = temp;
        }
    }
}

Console.WriteLine(MyFirstList[MyFirstList.Count - 2]);


Console.ReadLine();
