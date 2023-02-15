namespace CSharpAlgorithms.Sorting
{
    public static class InsertionSort
    {
        public static void Sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = i; j > 0 && arr[j - 1] > arr[j]; j--)
                {
                    (arr[j - 1], arr[j]) = (arr[j], arr[j - 1]);
                }
            }
        }
    }
}
