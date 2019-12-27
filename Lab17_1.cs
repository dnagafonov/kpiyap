using System;
using System.Linq;

namespace kpiyap
{
    public class Lab17_1
    {
        private int[] arr;

        public int[] Arr
        {
            get => arr;
            set => arr = value;
        }

        public Lab17_1(){}
        public Lab17_1(int[] arr)
        {
            Arr = arr;
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

        public void referenceSetArr(ref int[] arr)
        {
            Arr = arr;
        }

        public static void getMul(ref Lab17_1 arr1, ref Lab17_1 arr2, out Lab17_1 outObj)
        {
            outObj = arr1 * arr2;
        }

        public static Lab17_1 operator *(Lab17_1 arr1, Lab17_1 arr2)
        {
            int[] arr = new int[arr1.Arr.Length > arr2.Arr.Length ? arr1.Arr.Length : arr2.Arr.Length];
            Lab17_1 res = new Lab17_1();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += arr1.Arr[i] * arr2.Arr[i];
            }
            res.Arr = arr;
            return res;
            
        }

        public static bool operator ==(Lab17_1 a, Lab17_1 b)
        {
            if (a.Arr.Length == b.Arr.Length)
            {
                for (int i = 0; i < a.Arr.Length; i++)
                    if (a.Arr[i] != b.Arr[i])
                        return false;
                return true;
            }
            return false;
        } 
        public static bool operator !=(Lab17_1 a, Lab17_1 b)
        {
            if (a.Arr.Length == b.Arr.Length)
            {
                for (int i = 0; i < a.Arr.Length; i++)
                    if (a.Arr[i] != b.Arr[i])
                        return true;
                return false;
            }
            return false;
        } 
        public static bool operator >=(Lab17_1 a, Lab17_1 b)
        {
            int res1 = a.Arr.Sum(i => i); 
            int res2 = b.Arr.Sum(i => i);
            return res1 >= res2;
        }
        
        public static bool operator <=(Lab17_1 a, Lab17_1 b)
        {
            int res1 = a.Arr.Sum(i => i); 
            int res2 = b.Arr.Sum(i => i);
            return res1 <= res2;
        } 
    }
}