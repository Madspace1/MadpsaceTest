using System;
using System.Collections;
using System.Data;
using _39_Expandable_List;

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

            if (myArrayList.Count == myArrayList.MyCapacity)
            {
                myArrayList.Print();

                Console.WriteLine("Enter the index of the element to be deleted:");
                string indexInput = Console.ReadLine();
                if (int.TryParse(indexInput, out int index))
                {
                    myArrayList.Remove(index);
                }
                else
                {
                    Console.WriteLine("Invalid index. Please enter a valid integer.");
                }

                myArrayList.Print();

                Console.WriteLine("Enter a number to check if it is in the array:");
                string checkContains = Console.ReadLine();
                if (int.TryParse(checkContains, out int ContainsNumberCheck))
                {
                    if (myArrayList.Contains(ContainsNumberCheck) == true) 
                    {
                        Console.WriteLine($"Yes, number {ContainsNumberCheck} exist in array");
                    }
                    if (myArrayList.Contains(ContainsNumberCheck) == false) 
                    {
                        Console.WriteLine($"No, number {ContainsNumberCheck} does NOT exist in array");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid number. Please enter a valid integer.");
                }

                Console.WriteLine("Enter 'clear' to clear your array or any other key to exit:");
                string clearInput = Console.ReadLine();
                if (clearInput.Equals("clear", StringComparison.OrdinalIgnoreCase))
                {
                    myArrayList.Clear();
                    Console.WriteLine();
                    myArrayList.Print();
                    lestDoit = false;
                }
                else
                {
                    Console.WriteLine();
                    myArrayList.Print();
                    Console.WriteLine();
                    lestDoit = false;
                }
            }
        }
    }
}