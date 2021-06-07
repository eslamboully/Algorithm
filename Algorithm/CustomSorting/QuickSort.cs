using System;

namespace Algorithm.CustomSorting
{
    public class QuickSort
    {
        public int[] DoQuickSort(int[] UnsortedList, int low,int high)
        {
            if (low >= high) { return UnsortedList; }
            int pivot = UnsortedList[low];
            int i = low;
            int j = high;

            while (i <= j)
            {
                while (UnsortedList[i] < pivot) { i++; }
                while (UnsortedList[j] > pivot) { j--; }

                if (i <= j)
                {
                    int temp = UnsortedList[i];
                    UnsortedList[i] = UnsortedList[j];
                    UnsortedList[j] = temp;
                    i++;
                    j--;
                }

                if (low < j)
                {
                    DoQuickSort(UnsortedList,low,j);
                }

                if (high > i)
                {
                    DoQuickSort(UnsortedList, i, high);
                }
            }
            
            return UnsortedList;
        }
    }
}