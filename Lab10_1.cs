using System;

namespace kpiyap
{
    public class Lab10_1
    {
        private int m;
        private int n;
        private int sum = 0;
        private int mul = 1;

        public Lab10_1(int m, int n)
        {
            this.m = m;
            this.n = n;
        }
        
        public void getSum()
        {
            for (int i = m; i < n; i += m)
            {
                sum += 2 * i;
            }

            Console.WriteLine("Sum: " + sum);
        }

        public void getMul()
        {
            for (int i = m; i < n; i += m)
            {
                mul *= 2 * i;
            }

            Console.WriteLine("Mul: " + mul+ "\n");
        }
    }
}