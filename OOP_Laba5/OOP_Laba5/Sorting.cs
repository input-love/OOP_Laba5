using System;

namespace OOP_Laba5
{
    abstract class Sorting
    {
        abstract public void sort(ref int[] arr, int size);
        public void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
