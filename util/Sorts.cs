using System;
using System.Collections.Generic;

namespace kpiyap.util
{
    class SortCounter
     {
         private List<Counter> Counters;

         public SortCounter()
         {
             Counters = new List<Counter>();
         }

         private void addItems()
         {
             Counters.Add(new Counter(1, 4, "6"));
             Counters.Add(new Counter(2,2,"2"));
             Counters.Add(new Counter(3,3,"3"));
         }
        public void sortItems()
        {
            addItems();
            Console.WriteLine("Unsorted counters: ");
            int temp = 1;
            foreach (var counter in Counters)
            {
                Console.WriteLine($"{temp++})" + counter.Id);
            }

            Counters.Sort((counter1, counter2) => { return counter1.Id.CompareTo(counter2.Id); });
            int temp1 = 1;
            Console.WriteLine("\nSorted counters: ");
            foreach (var counter in Counters)
            {
                Console.WriteLine($"{temp1++})" + counter.Id);
            }
        }
    }
}