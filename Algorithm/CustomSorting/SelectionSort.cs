namespace Algorithm.CustomSorting
{
    public class SelectionSort
    {
        private int[] UnsortedList = { 10, 4, 8, 6, 7};
        private int MinIndex = 0;
        private int MinimumValueFound = 0;

        public int[] DoSelectionSort()
        {
            for (int i = 0; i < UnsortedList.Length; i++)
            {
                MinIndex = i;
                for (int j = MinIndex+1; j < UnsortedList.Length; j++)
                {
                    if (UnsortedList[MinIndex] > UnsortedList[j])
                    {
                        MinIndex = j;
                    }
                }

                MinimumValueFound = UnsortedList[MinIndex];
                UnsortedList[MinIndex] = UnsortedList[i];
                UnsortedList[i] = MinimumValueFound;
            }
            
            return UnsortedList;
        }
    }
}