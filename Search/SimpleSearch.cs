
namespace CSharpAlgorithms.Search
{
    public static class SimpleSearch
    {
        /// <summary>
        /// Поиск элемента в массиве
        /// </summary>
        /// <param name="arr">Массив</param>
        /// <param name="value">Значение, которое нужно найти</param>
        /// <returns>Индекс найденного элемента или -1</returns>
        public static int Search(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if(value == arr[i])
                    return i;
            }
            return -1;
        }
    }
}
