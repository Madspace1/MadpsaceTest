using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _38_Create_a_Basic_Static_Size_List
{
    internal class MyArrayList
    {
        public int[] MyArray { get; set; }
        public int Count { get; set; }
        public int MyCapacity { get; set; }

        public MyArrayList()
        {
            MyCapacity = 10;
            MyArray = new int[MyCapacity];
            Count = 0;
        }

        public void Add(int number)
        {
            if (Count < MyCapacity)
            {
                MyArray[Count] = number;
                Count++;
            }
        
            else
            {
                Console.WriteLine("List is full. Cannot add more elements.");
            }
        }
    }
}