namespace Algorithm.Sorting
{
    public class InsertionSort
    {
        public int[] UnsortedList = { 10, 4, 8, 6, 7};
        
        public int[] DoInsertionSort()
        {
            for (int i = 0; i < UnsortedList.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (UnsortedList[j - 1] > UnsortedList[j])
                    {
                        int temp = UnsortedList[j - 1];
                        UnsortedList[j - 1] = UnsortedList[j];
                        UnsortedList[j] = temp;
                    }
                }
            }
            return UnsortedList;
        }
    }
}