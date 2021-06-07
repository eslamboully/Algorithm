namespace Algorithm.Sorting
{
    public class BubbleSort
    {
        public int[] UnsortedList = { 10, 4, 8, 6, 7};
        public int temp;

        public int[] DoBubbleSort()
        {
            //  length is 5
            for(int i=0;i < UnsortedList.Length;i++)
            {
                for (int j = 1; j < UnsortedList.Length - i; j++)
                {
                    if (UnsortedList[j-1] > UnsortedList[j])
                    {
                        temp = UnsortedList[j-1];
                        UnsortedList[j-1] = UnsortedList[j];
                        UnsortedList[j] = temp;
                    }
                }
            }

            return UnsortedList;
        }
    }
}