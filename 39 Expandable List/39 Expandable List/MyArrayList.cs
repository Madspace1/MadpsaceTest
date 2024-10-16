using System;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace New_array_29_07
{
    internal class MyArrayList<T>  : IEnumerable<T>, ICollection<T>, ICloneable where T : IComparable<T>
    {
        private T[] MyArray;
        public int Count { get; private set; }
        public int Capacity => MyArray.Length;
        public bool IsReadOnly { get; set; }

        public MyArrayList()
        {
            MyArray = new T[5];
            Count = 0;
            IsReadOnly = false;
        }
        public void Sort()
        {
            for (int i = 0; i < Count - 1; i++)
            {
                for (int j = i + 1; j < Count; j++)
                {
                    if (MyArray[i].CompareTo(MyArray[j]) > 0)
                    {
                        T temp = MyArray[i];
                        MyArray[i] = MyArray[j];
                        MyArray[j] = temp;
                    }
                }
            }
        }
        public bool BinarySearch(T number)
        {
           Sort();

            int left = 0;
            int right = Count - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (MyArray[mid].CompareTo(number) == 0)
                {
                    return true;
                }
                else if (number.CompareTo(MyArray[mid]) <0)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return false;
        }
            

            public MyArrayList<T> Clone()
        {
            MyArrayList<T> newMyArrayList = new MyArrayList<T>();

            foreach (T item in this)
            {
                newMyArrayList.Add(item);
            }

            newMyArrayList.IsReadOnly = this.IsReadOnly;

            Console.WriteLine("The CLONING was successful");
            Console.WriteLine("This is clone of your array:");

            return newMyArrayList;
        }

        public MyArrayList(MyArrayList<T> otherMyArrayList)
        {
            MyArray= new T[otherMyArrayList.Capacity];
            Array.Copy(otherMyArrayList.MyArray, MyArray, otherMyArrayList.Count);
            Count = otherMyArrayList.Count;
            IsReadOnly = otherMyArrayList.IsReadOnly;

        }
        object ICloneable.Clone() //це щоб прога не ругалася, оскільки реалізація метода обовязкова для використання ICloneable
        {      
            return Clone();
        }

        public void Update(int updateIndex, T newValue)
        {
            if (IsReadOnly)
            return;
            MyArray[updateIndex] = newValue;
            Console.WriteLine("Element updated.");
        }

        public MyArrayList<T> FindAll(Predicate<T> match)
        {
            if (match == null)
                return new MyArrayList<T>();

            MyArrayList<T> result = new MyArrayList<T>();

            for (int i = 0; i < Count; i++)
            {
                if (match(MyArray[i]))
                {
                    result.Add(MyArray[i]);
                }
            }

            return result;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return MyArray[i];
            }
        }

        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        public T Find(Predicate<T> match)
        {
            if (match == null)
                return default;

            for (int i = 0; i < Count; i++)
            {
                if (match(MyArray[i]))
                {
                    return MyArray[i];
                }
            }

            return default;
        }

        public void TrimExcess()
        {
            if (IsReadOnly) return;

            if (Count < MyArray.Length)
            {
                T[] array2 = new T[Count];
                Array.Copy(MyArray, array2, Count);
                MyArray = array2;
                Console.WriteLine($"Array capacity reduced. New capacity: {MyArray.Length}, Count: {Count}");
            }
            else
            {
                Console.WriteLine("No need to trim excess as the capacity is optimally used.");
            }
        }
        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array == null)
            {
                Console.WriteLine("The destination array cannot be null.");
                return;
            }

            if (arrayIndex < 0)
            {
                Console.WriteLine("Array index must be greater than or equal to zero.");
                return;
            }

            for (int i = arrayIndex; i < Count+ arrayIndex; i++)
            {
                array[i] = MyArray[i - arrayIndex];
            }

            Console.WriteLine("Elements successfully copied.");
        }
        public bool Remove(T item)
        {
            if (IsReadOnly) return false;
            int index = IndexOf(item);
            if (index == -1)
            {
                return false;
            }

            for (int i = index; i < Count - 1; i++)
            {
                MyArray[i] = MyArray[i + 1];
            }

            Count--;
            Console.WriteLine("Element removed.");
            return true;
        }

        public void Clear()
        {
            if (IsReadOnly) return;
            Count = 0;
            Console.WriteLine("List cleared.");
        }

        public int IndexOf(T number)
        {
            for (int i = 0; i < Count; i++)
            {
                if (MyArray[i].CompareTo(number) == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        public void Reverse()
        {
            if (IsReadOnly) return;
            T temp;
            for (int i = 0; i < Count / 2; i++)
            {
                int j = Count - i - 1;

                temp = MyArray[i];
                MyArray[i] = MyArray[j];
                MyArray[j] = temp;
            }
            Console.WriteLine("Reverse successfully!");
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                {
                    Console.WriteLine("Index is out of range.");
                    return default(T);
                }
                return MyArray[index];
            }
            set
            {
                if (IsReadOnly) return;
                if (index < 0 || index >= Count)
                {
                    Console.WriteLine("Index is out of range.");
                }
                else
                {
                    MyArray[index] = value;
                }
            }
        }

        public void Add(T element)
        {
            if (IsReadOnly) { Console.WriteLine("ReadOnly MODE is active! you can't do any changes"); return; }
            
            if (Count >= MyArray.Length)
            {
                Expand();
            }
            MyArray[Count] = element;
            Count++;
        }

        public void Insert(int index, T element)
        {
            if (IsReadOnly) return;
            if (index.CompareTo(index) < 0 || index.CompareTo(Count) > 0)
            {
                Console.WriteLine("Index is out of range.");
                return;
            }

            if (Count >= MyArray.Length)
            {
                Expand();
            }

            for (int i = Count; i.CompareTo(index) > 0; i--)
            {
                MyArray[i] = MyArray[i - 1];
            }

            MyArray[index] = element;
            Count++;
        }

        private void Expand()
        {
            if (IsReadOnly) return;
            int newCapacity = MyArray.Length * 2;
            T[] newArray = new T[newCapacity];
            Array.Copy(MyArray, newArray, MyArray.Length);
            MyArray = newArray;
        }

        public void Print()
        {
            Console.WriteLine();
                   
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(MyArray[i]);
            }
            Console.WriteLine();
        }

        public bool Contains(T num)
        {
            for (int i = 0; i < Count; i++)
            {
                if (MyArray[i].CompareTo(num) == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}