namespace kpiyap.util
{
    public static class Sorts<T>
    {
        private static void swap(Counter a, Counter b)
        {
            Counter temp = a;
            a = b;
            b = temp;
        }
        public static void bubbleSort(ref Counter[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
            {
                for (int j = 0; j < arr.Length - i - 1; ++j)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        swap(arr[j], arr[j+1]);
                    }
                }
            }
        }
    }
}