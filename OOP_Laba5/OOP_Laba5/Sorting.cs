using System;

namespace OOP_Laba5
{
    abstract class Sorting
    {
        abstract public int[] sort(int[] arr, int size);
        public void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
