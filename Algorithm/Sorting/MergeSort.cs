using System;

namespace Algorithm.Sorting
{
    public class MergeSort
    {
        public int[] UnsortedList = { 10, 4, 8, 6, 7};
        
        private void Merge(int[] UnsortedList, int low, int middle, int high)
        {
            int[] lowArray = new int[middle - low + 1];
            int[] highArray = new int[high - middle];
 
            Array.Copy(UnsortedList, low, lowArray, 0, middle - low + 1);
            Array.Copy(UnsortedList, middle + 1, highArray, 0, high - middle);
 
            int i = 0;
            int j = 0;
            for (int k = low; k < high + 1; k++)
            {
                if (i == lowArray.Length)
                {
                    UnsortedList[k] = highArray[j];
                    j++;
                }
                else if (j == highArray.Length)
                {
                    UnsortedList[k] = lowArray[i];
                    i++;
                }
                else if (lowArray[i] <= highArray[j])
                {
                    UnsortedList[k] = lowArray[i];
                    i++;
                }
                else
                {
                    UnsortedList[k] = highArray[j];
                    j++;
                }
            }
        }
        
        public int[] DoMergeSort(int[] UnsortedList, int low, int high)
        {
            if (low < high)
            {
                int middle = (low + high) / 2;
 
                DoMergeSort(UnsortedList, low, middle);
                DoMergeSort(UnsortedList, middle + 1, high);
 
                Merge(UnsortedList, low, middle, high);
            }

            return UnsortedList;
        }
    }
}