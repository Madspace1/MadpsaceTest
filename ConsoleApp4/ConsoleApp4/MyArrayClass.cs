using System;

namespace _39_Expandable_List
{
    internal class MyArrayList
    {
        public int[] MyArray { get; private set; }
        public int Count { get; private set; }
        public int MyCapacity { get; private set; }

        public MyArrayList()
        {
            MyCapacity = 10;
            MyArray = new int[MyCapacity];
            Count = 0;
        }

        public void Add(int number)
        {
            if (Count >= MyCapacity)
            {
                Expand();
            }
            MyArray[Count] = number;
            Count++;
        }

        public void Expand()
        {
            MyCapacity *= 2;
            int[] newArray = new int[MyCapacity];
            for (int i = 0; i < Count; i++)
            {
                newArray[i] = MyArray[i];
            }
            MyArray = newArray;
        }

        public void Remove(int index)
        {
            if (index < 0 || index >= Count)
            {
                Console.WriteLine("Index out of range. Please enter a valid index.");
                return;
            }

            for (int i = index; i < Count - 1; i++)
            {
                MyArray[i] = MyArray[i + 1];
            }
            Count--;
        }
        public bool Contains(int num)
        {
            for (int i = 0; i < Count; i++)
            {
                if (MyArray[i] == num)
                {
                    return true;
                }
            }
            return false;
        }
        public void Clear()
        {
            for (int i = 0; i <= Count; i++)
            {
                MyArray[i] = 0;
            }
            Count = 0;
        }
        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine("==============================");
            Console.WriteLine("Current List: ");
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(MyArray[i]);
            }
        }
    }
}