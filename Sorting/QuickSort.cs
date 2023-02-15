namespace CSharpAlgorithms.Sorting
{
    public static class QuickSort
    {
        public static int[] Sort(int[] arr)
        {
            if (arr.Length < 2)
                return arr;

            int pivot = GetPivot(arr);

            int[] left = new int[0];
            int[] right = new int[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] <= pivot)
                    left = left.Append(arr[i]).ToArray();
                if (arr[i] > pivot)
                    right = right.Append(arr[i]).ToArray();
            }

            left = Sort(left);
            right = Sort(right);

            int[] result = left.Append(pivot).Concat(right).ToArray();
            return result;
        }

        // not done
        private static int GetPivot(int[] arr)
        {
            return arr[0];
        }
    }
}
