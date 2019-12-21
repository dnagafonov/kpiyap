using System;
namespace kpiyap
{
    delegate (double, double) UP(double x);
    internal delegate void Message();

    static class MyClassEventArgs
    {
        public static void initialMes()
        {
            Console.WriteLine("Initialed.\n");
        }
        public static void sortMes()
        {
            Console.WriteLine("\nSorting...");
        }
        public static void addMes()
        {
            Console.WriteLine("Adding people...");
        }
    }
    class Lab14_15
    {
        public static (double, double) task1(UP up)
        {
            double x = 0;
            (double, double) tuple = (0, 0);
            for (double i = -1; i <= 0; i += 0.2)
            {
                x += 0.2;
                tuple = up(x);
            }
            return tuple;
        }

        public static (double, double) mathodUP(double x)
        {
            return (Math.Sin(x), Math.Cos(x));
        }
    }
}