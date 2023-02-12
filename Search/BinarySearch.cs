using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
