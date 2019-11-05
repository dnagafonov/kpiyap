using System;

namespace kpiyap
{
    public static class Lab1
    {
        public static void task1()
        {
            double x = 14.26;
            double y = -1.22;
            double z = 0.035;
            double t = 0.564846;
            double res = ((2 * Math.Cos(x - Math.PI / 6)) / (0.5 + Math.Pow(Math.Sin(y), 2))) *
                         (1 + (Math.Pow(z, 2) / (3 - (Math.Pow(z, 2)) / 5)));
            Console.WriteLine(t == Math.Round(res,6));
        }

        public static void task2()
        {
            int a = 2;
            int b = 4;
            int c = 6;
            Console.WriteLine(a % 2 == 0 && b % 2 == 0 && c % 2 == 0);
        }
    }

    public static class Lab2
    {
        public static void task1()
        {
            int x = 2;
            Console.WriteLine((Math.Pow(x,2) - (5 * Math.Sqrt(2))) / (2 * Math.Pow(x,3) + 1));
        }

        public static int factorial(int n)
        {
            return n == 1 ? 1 : n * factorial(n - 1);
        }

        public static void task2()
        {
            int x = 2;
            int n = 5;
            double temp = 0;
            while (n > 0)
            {
                temp += Math.Pow(x, n) / factorial(n);
                n--;
            }
            Console.WriteLine(1 + temp);
        }
    }
    public static class Lab3
    {
        public static void task1()
        {
            double xn = 0.1;
            double xk = 1;
            for(double i = xn; i <= xk; i += (xk - xn) / 10)
            {
                Console.WriteLine(Math.Sin(i));
            }
        }

        public static void task2()
        {
            int num = 2323;
            if (num > 0)
            {
                Console.WriteLine(num.ToString().ToCharArray().Length);
            }
            else
            {
                Console.WriteLine("is negative");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Lab3.task1();
            Console.ReadLine();
        }
    }
}