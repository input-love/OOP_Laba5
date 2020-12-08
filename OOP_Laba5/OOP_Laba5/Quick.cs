using System;

namespace OOP_Laba5
{
    class Quick: Sorting
    {
        public override void sort(ref int[] arr, int size)
        {
            quick_sort(ref arr, 0, size - 1);
        }
        private void quick_sort(ref int[] arr, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return;
            }

            var pivotIndex = partition(ref arr, minIndex, maxIndex);
            quick_sort(ref arr, minIndex, pivotIndex - 1);
            quick_sort(ref arr, pivotIndex + 1, maxIndex);
        }
        private int partition(ref int[] arr, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (arr[i] < arr[maxIndex])
                {
                    pivot++;
                    swap(ref arr[pivot], ref arr[i]);
                }
            }

            pivot++;
            swap(ref arr[pivot], ref arr[maxIndex]);
            return pivot;
        }
    }
}
