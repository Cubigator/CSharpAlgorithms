namespace CSharpAlgorithms.Search
{
    public static class BinarySearch
    {
        public static int Search(int[] arr, int value)
        {
            int left = 0, right = arr.Length - 1;
            int index;

            while (left <= right)
            {
                index = ((right + left) % 2 == 0) ? (right + left) / 2 : (right + left) / 2 + 1;

                if (arr[index] == value)
                    return index;
                if (arr[index] > value)
                    right = index - 1;
                if (arr[index] < value)
                    left = index + 1;
            }

            return -1;
        }

        public static int SearchRecursive(int[] arr, int value)
        {
            int index = FindInsertionIndex(arr, 0, arr.Length - 1, value);
            return (arr[index] == value) ? index : -1;
        }

        private static int FindInsertionIndex(int[] arr, int left, int right, int value)
        {
            if(left == right) 
                return left;

            int mid = (right + left) / 2;

            if (arr[mid] == value)
                return mid;

            if (arr[mid] <= value)
            {
                return FindInsertionIndex(arr, mid + 1, right, value);
            }
            else
            {
                return FindInsertionIndex(arr, left, mid, value);
            }
        }
    }
}
