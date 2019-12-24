using System;

namespace kpiyap
{
    public class Lab17_1
    {
        private int[] arr;

        public Lab17_1(){}
        public Lab17_1(int[] arr)
        {
            this.arr = arr;
        }

        ~Lab17_1()
        {
            Console.WriteLine("Deleted");
        }

        public int this[int index]
        {
            get => arr[index];
            set
            {
                if (index <= arr.Length && index > 0)
                    arr[index] = value;
                else
                    throw new Exception("Incorrect value");
            }
        }
    }
}