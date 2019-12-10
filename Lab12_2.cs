using System;
using kpiyap.util;

namespace kpiyap
{
    interface IMyClonable:ICloneable
    {
        Counter myClone();
    }
    public class Counter:IMyClonable
    {
        private int number;
        private int id;
        private string name;

        public int Number { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        
        public Counter(){}

        public Counter(int number, int id, string name)
        {
            if (number > 10)
            {
                int length = number.ToString().Length - 1;
                Number = number / ((int) Math.Pow(10, length));
            }
            else
                Number = number; 
            Id = id;
            Name = name;
        }
        public static bool operator >(Counter a, Counter b)
        {
            return a.id > b.id;
        }

        public static bool operator <(Counter a, Counter b)
        {
            return a.id < b.id;
        }

        public static void sortItems()
        {
            Counter[] counters = new[] {new Counter(1, 1, "1"), new Counter(2,2,"2"), new Counter(3,3,"3")};
            Sorts<int>.bubbleSort(ref counters);
            foreach (var VARIABLE in counters)
            {
                Console.WriteLine(VARIABLE.id);
            }
        }

        public Counter myClone()
        {
            return new Counter(Number, Id, Name);
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}