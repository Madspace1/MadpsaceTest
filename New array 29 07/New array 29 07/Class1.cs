using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_array_29_07
{
    internal class Class1
    {
        public int this[int index]
        {
            get
            {
                return MyArray[index];
            }
            set
            {
                MyArray[index] = value;
            }
        }
        public int[] MyArray { get; set; }
        public Class1() 
        { 
        MyArray = new int[5];
        }
       
        public void Insert(int index, int InsertElement) 
        {
            MyArray[index] = InsertElement;
        }
    }
}
