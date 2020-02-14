using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using kpiyap.practice;

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

    public enum operations
    {
        sum, count
    }

    public enum numberType
    {
        active, negative
    }
    public class Lab4
    {
        public numberType _numberType { get; set; }

        public operations _operations { get; set; }

        public int[] array { get; set; }
        public Lab4(){}
        
        public void getSumSwithcase()
        {
            int sum = 0;
            int count = 0;
            switch (_operations)
            {
                case (operations.sum):
                    switch (_numberType)
                    {
                        case (numberType.active):
                            for (int i = 0; i != array.Length; ++i)
                            {
                                if (array[i] > 0)
                                {
                                    sum += array[i];
                                }
                            }
                            Console.WriteLine("Sum of active: " + sum);
                            break;
                        case (numberType.negative):
                            for (int i = 0; i != array.Length; ++i)
                            {
                                if (array[i] < 0)
                                {
                                    sum += array[i];
                                }
                            }
                            Console.WriteLine("Sum of negative: " + sum);
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case (operations.count):
                    switch (_numberType)
                    {
                        case (numberType.active):
                            for (int i = 0; i != array.Length; ++i)
                            {
                                if (array[i] > 0)
                                {
                                    count++;
                                }
                            }
                            Console.WriteLine("Count of active: " + count);
                            break;
                        case (numberType.negative):
                            for (int i = 0; i != array.Length; ++i)
                            {
                                if (array[i] < 0)
                                {
                                    count++;
                                }
                            }
                            Console.WriteLine("Count of negative: " + count);
                            break;
                        default: 
                            return;
                    }
                    break;
            }
        }

        public void task2()
        {
            int indexMin = Array.IndexOf(array, array.Min());
            int indexMax = Array.IndexOf(array, array.Max());
            int amount = 0;
            for (int i = indexMin; i != indexMax; ++i)
            {
                amount += array[i];
            }
            Console.WriteLine("Amount min____max: " + amount);
        }
    }

    class Bird
    {
        private int age { get; }
        private string name;
        public Bird(){}

        public Bird(string name, int age)
        {
            this.age = age;
            this.name = name;
        }
    }

    class Sparrow : Bird
    {
        public string food { get; }

        public Sparrow(string name, int age, string food) : base(name, age)
        {
            this.food = food;
        }
    }
    class Program
    {
        public static void f1(string str)
        {
            Regex regex = new Regex(@"<b>(.*)<\/b>");
            Console.WriteLine(regex.Matches(str)[0].Groups[1].Value);
        }

        public static int nod(int a, int b)
        {
            return a == b ? a : nod(Math.Max(a, b) - Math.Min(a,b), Math.Min(a,b));
        }
        
        
        static void Main(string[] args)
        {
            
            try
            {
                Film film = new Film("n",1901,new List<Genre>(3){Genre.Comedy, Genre.Drama, Genre.Melodrama},"fd", 2000);
                Console.WriteLine(film);
            }
            catch (CustomException e)
            {
                Console.WriteLine(e.Message + "\n" + e.StackTrace);
            }
            Console.ReadLine();
        }
    }
}