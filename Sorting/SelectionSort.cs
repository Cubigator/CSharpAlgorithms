namespace CSharpAlgorithms.Sorting
{
    public static class SelectionSort
    {
        public static void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minimum = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[minimum] > arr[j])
                    {
                        minimum = j;
                    }
                }
                (arr[minimum], arr[i]) = (arr[i], arr[minimum]);
            }
        }
    }
}
