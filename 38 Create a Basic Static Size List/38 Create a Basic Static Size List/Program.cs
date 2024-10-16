using System;
using _38_Create_a_Basic_Static_Size_List;

class Program
{
    static void Main()
    {
        MyArrayList myArrayList = new MyArrayList();
        bool lestDoit = true;
        Console.WriteLine("Enter the numbers of your LIST:");
        while (lestDoit)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                myArrayList.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid number. Please enter a valid integer.");
            }
            if (myArrayList.Count == 10)
            {
                Console.WriteLine();
                Console.WriteLine("==============================");
                Console.WriteLine("Current List: ");
                foreach (var num in myArrayList.MyArray)
                {
                    Console.WriteLine(num);
                }
                Console.WriteLine("              Thx you =)");
                lestDoit = false;
            }
        }
    }
}