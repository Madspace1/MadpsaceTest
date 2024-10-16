using New_array_29_07;
using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Collections;
using System.ComponentModel;

class Program
{
    static void Main()
    {
        MyArrayList<int> myArrayList = new MyArrayList<int>();
        
        bool continueRunning = true;

        while (continueRunning)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add numbers to the list");
            Console.WriteLine("2. Remove element");
            Console.WriteLine("3. Get element by index");
            Console.WriteLine("4. Update element by index");
            Console.WriteLine("5. Clear the list");
            Console.WriteLine("6. Print the list");
            Console.WriteLine("7. Check if a number is in the list");
            Console.WriteLine("8. Insert element by index");
            Console.WriteLine("9. Reverse");
            Console.WriteLine("10. Find index of");
            Console.WriteLine("11. Copy to another array starting at a given index");
            Console.WriteLine("12. TrimExcess (reduce the capacity of the list to match the count)");
            Console.WriteLine("13. Find number in list");
            Console.WriteLine("14. Find all numbers in list");
            Console.WriteLine("15. Toggle ReadOnly Mode");
            Console.WriteLine("16. Сlone your array");
            Console.WriteLine("17. Use CopyConstructor");
            Console.WriteLine("18. BinarySearch");
            Console.WriteLine("19. Exit");

            Console.Write("Choose an action (1-19): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int choice))
            {
                if (choice == 1)
                {
                    Console.WriteLine("Enter numbers to add to the list (enter 'done' to finish):");
                    while (true)
                    {
                        Console.Write("Enter a number: ");
                        input = Console.ReadLine();
                        if (input.ToLower() == "done")
                            break;

                        if (int.TryParse(input, out int number))
                        {
                            myArrayList.Add(number);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter an integer.");
                        }
                    }
                }
                else if (choice == 2)
                {
                    Console.Write("Enter which number do you want to remove: ");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out int number))
                    {
                        myArrayList.Remove(number);   
                    }
                    else
                    {
                        Console.WriteLine("Invalid index. Please enter an integer.");
                    }
                }
                else if (choice == 3)
                {
                    Console.Write("Enter the index to get the element: ");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out int getIndex))
                    {
                        Console.WriteLine(myArrayList[getIndex]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index. Please enter an integer.");
                    }
                }
                else if (choice == 4)
                {
                    Console.Write("Enter the index to update: ");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out int updateIndex))
                    {
                        Console.Write("Enter the new value: ");
                        input = Console.ReadLine();
                        if (int.TryParse(input, out int newValue))
                        {
                            myArrayList.Update(updateIndex, newValue);
                        }
                        else
                        {
                            Console.WriteLine("Invalid number. Please enter an integer.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid index. Please enter an integer.");
                    }
                }
                else if (choice == 5)
                {
                    myArrayList.Clear();
                    
                }
                else if (choice == 6)
                {
                    {
                        myArrayList.Print();
                    }
                }
                else if (choice == 7)
                {
                    Console.WriteLine("Enter a number to check if it is in the array:");
                    string checkContains = Console.ReadLine();
                    if (int.TryParse(checkContains, out int ContainsNumberCheck))
                    {
                        if (myArrayList.Contains(ContainsNumberCheck))
                        {
                            Console.WriteLine($"Yes, number {ContainsNumberCheck} exists in the array");
                        }
                        else
                        {
                            Console.WriteLine($"No, number {ContainsNumberCheck} does NOT exist in the array");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid number. Please enter a valid integer.");
                    }
                }
                else if (choice == 8)
                {
                    Console.Write("Enter index of array for insert: ");
                    int ind = int.Parse(Console.ReadLine());
                    Console.Write("Enter your insert number: ");
                    int number = int.Parse(Console.ReadLine());

                    myArrayList.Insert(ind, number);
                }
                else if (choice == 9)
                {
                    myArrayList.Reverse();
                }
                else if (choice == 10)
                {
                    Console.WriteLine("Enter the number to find out its index");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out int index))
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Index of number {input} is : {myArrayList.IndexOf(index)}");

                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 19.");
                    }
                }
                else if (choice == 11)
                {
                    Console.WriteLine("Enter the index to start copying from: ");
                    input = Console.ReadLine();

                    if (int.TryParse(input, out int index))
                    {
                        int[] newArray = new int[30];

                        if (index < 0 || newArray.Length - index < myArrayList.Count)
                        { 
                            Console.WriteLine("Index is out of bounds.");
                        }
                        else
                        {
                            myArrayList.CopyTo(newArray, index);

                            foreach (int i in newArray)
                            {
                                Console.WriteLine(i);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid index. Please enter an integer.");
                    }
                }
                else if (choice == 12)
                {
                    Console.WriteLine($"Before TrimExcess: Capacity = {myArrayList.Capacity}, Count = {myArrayList.Count}");
                    myArrayList.TrimExcess();
                    Console.WriteLine($"After TrimExcess: Capacity = {myArrayList.Capacity}, Count = {myArrayList.Count}");
                }
                else if (choice == 13)
                {
                    Console.Write("Enter the number to start searching: ");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out int element))
                    {
                        int result = myArrayList.Find(x => x == element);

                        if (result != default)
                        {
                            Console.WriteLine($"Element found: {result}");
                        }
                        else
                        {
                            Console.WriteLine("Element not found.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid number. Please enter an integer.");
                    }
                }
                else if (choice == 14)
                {
                    Console.Write("Enter the number to start searching: ");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out int element))
                    {
                        var foundElements = myArrayList.FindAll(x => x == element);

                        if (foundElements.Count > 0)
                        {
                            foundElements.Print();
                        }
                        else
                        {
                            Console.WriteLine("No elements found.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid number. Please enter an integer.");
                    }

                }
                else if (choice == 15)
                {
                    myArrayList.IsReadOnly = !myArrayList.IsReadOnly;
                    Console.WriteLine($"ReadOnly mode is now {(myArrayList.IsReadOnly ? "enabled" : "disabled")}.");
                }
                else if (choice == 16)
                {
                    MyArrayList<int> myArrayList2 = new MyArrayList<int>();
                    myArrayList2 = myArrayList.Clone();
                    myArrayList2.Print();
                }
                else if (choice == 17)
                {
                    MyArrayList<int> copied_myArrayList = new MyArrayList<int>(myArrayList);
                    Console.WriteLine("Original List:");
                    myArrayList.Print();

                    Console.WriteLine("Copied List:");
                    copied_myArrayList.Print();

                }
                else if (choice == 18)
                {
                    Console.WriteLine("Enter the number for search:");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out int element))
                    {
                        bool finded = myArrayList.BinarySearch(element);
                        if (finded)
                        { Console.WriteLine("Your number finded successfully"); }
                        else
                        { Console.WriteLine($"Not founded number {element} in array"); }
                    }
                    else
                    {
                        Console.WriteLine("Error. Please enter an integer.");
                    }
                }
                else if (choice == 19)
                {
                    continueRunning = false;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 19.");
                }

                if (choice != 19 & choice != 6)
                {
                    Console.WriteLine("Current LIST:");
                    myArrayList.Print();
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 19.");
            }
        }
    }
}