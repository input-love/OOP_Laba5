using System;

namespace OOP_Laba5
{
    class Quick: Sorting
    {
        public override int[] sort(int[] array, int size)
        {
            return quick_sort(array, 0, size - 1);
        }
        private int[] quick_sort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = partition(array, minIndex, maxIndex);
            quick_sort(array, minIndex, pivotIndex - 1);
            quick_sort(array, pivotIndex + 1, maxIndex);

            return array;
        }
        private int partition(int[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }
    }
}
