namespace CSharpAlgorithms.Sorting
{
    public static class MergeSort
    {
        public static int[] Sort(int[] arr)
        {
            if (arr.Length == 1) 
                return arr;

            int[] c = new int[arr.Length / 2];
            int[] d = new int[arr.Length - arr.Length / 2];

            int i = 0;
            int ci = 0;
            int di = 0;

            for (; i < arr.Length / 2; i++)
                c[ci++] = arr[i];

            for (; i < arr.Length; i++)
                d[di++] = arr[i];

            c = Sort(c);
            d = Sort(d);

            return Merge(c, d);
        }

        private static int[] Merge(int[] left, int[] right)
        {
            int n = left.Length + right.Length;

            int[] result = new int[n];

            int l = 0, r = 0;
            for (int i = 0; i < n; i++)
            {
                if (l >= left.Length)
                    result[i] = right[r++];
                else if (r >= right.Length)
                    result[i] = left[l++];
                else if (left[l] < right[r])
                    result[i] = left[l++];
                else
                    result[i] = right[r++];
            }
            return result;
        }
    }
}
