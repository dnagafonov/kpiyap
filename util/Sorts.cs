using System;

namespace kpiyap.util
{
    public static class Sorts<T>
    {
        private static void swap(ref Counter a, ref Counter b)
        {
            Counter temp = a;
            a = b;
            b = temp;
        }
        public static void bubbleSortForCounter(Counter[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
            {
                for (int j = 0; j < arr.Length - i - 1; ++j)
                {
                    if (arr[j].Id > arr[j + 1].Id)
                    {
                       swap(ref arr[j], ref arr[j+1]);
                    }
                }
            }

            int temp = 1;
            Console.WriteLine("\nSorted counters: ");
            foreach (var counter in arr)
            {
                Console.WriteLine($"{temp++})" + counter.Id);
            }
        }
    }

    static class SortCounter
    {
        public static void sortItems()
        {
            Counter[] counters = {new Counter(1, 4, "1"),
                                  new Counter(2,2,"2"),
                                  new Counter(3,3,"3")};
            Console.WriteLine("Unsorted counters: ");
            int temp = 1;
            foreach (var counter in counters)
            {
                Console.WriteLine($"{temp++})" + counter.Id);
            }
            Sorts<int>.bubbleSortForCounter(counters);
        }
    }
}