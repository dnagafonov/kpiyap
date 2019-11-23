using System;
using System.Collections.Generic;

namespace kpiyap
{
    public class Lab10test
    {
        private Lab10 lab10 = new Lab10(10);

        public static void getResultOfLab10()
        {
            int[] arr = new[] {2, 4, 6, 8, 10, 12};
            Lab10 lab10 = new Lab10(10);
            lab10.getSize();
            lab10.getDivAndMul(arr);
            lab10.getCurrentElement(arr, 3);
        }
    }
    public class Lab10
    {
        private const int scalar = 2;

        private List<int> list = new List<int>();
        public int this[int ind]
        {
            get { return list.Capacity > ind ? list[ind] : 0; }
        }
        public Lab10(){}

        public Lab10(List<int> list)
        {
            this.list = list;
        }

        public Lab10(int size)
        {
            this.list = new List<int>(size);
        }

        public void getSize()
        {
            Console.WriteLine("Capacity: " + list.Capacity);
        }

        public void getSumOfDigitWithSameSize(int[] arr1, int[] arr2)
        {
            if (arr1.Length == arr2.Length)
            {
                int[] sum = new int[arr1.Length];
                int[] subtraction = new int[arr1.Length];
                
                for (int i = 0; i != arr1.Length; ++i)
                {
                    sum[i] = arr1[i] + arr2[i];
                    subtraction[i] = arr1[i] - arr2[i];
                }
            }
        }

        public void getDivAndMul(int[] arr)
        {
            double[] divition = new double[arr.Length];
            double[] multiplication = new double[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                divition[i] = Convert.ToDouble(arr[i] / scalar);
                multiplication[i] = Convert.ToDouble(arr[i] * scalar);
            }

            Console.WriteLine("Division:");
            foreach (double d in divition)
            {
                Console.Write(d + " ");
            }

            Console.WriteLine("\nMultiplication: ");
            foreach (double d in multiplication)
            {
                Console.Write(d + " ");
            }
        }

        public void getCurrentElement(int[] arr, int index)
        {
            foreach (int i in arr)
            {
                list.Add(i);
            }

            list.FindIndex(0, (a) => a == 3);
            Console.WriteLine("\nBy current index: " + list[index]);
            Console.WriteLine("All elements:");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
        }
    }
}