﻿using System;
using System.Collections.Generic;
using System.Linq;
using kpiyap.util;

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
        static void Main(string[] args)
        {
            try
            {
                Group group = new Group();
                group.Min = 300;
                
                group.addStudent(new Student("Vorobey", "1", 9.2,400));
                group.addStudent(new Student("Ivan", "1", 7.2,60));
                group.addStudent(new Student("Ksenya", "1", 9.4,840));
                group.addStudent(new Student("Konstantin", "1", 5.1,30));
                group.addStudent(new Student("Nikita", "1", 6.2,100));
                group.addStudent(new Student("Vorobey", "1", 9.2,40));
                group.addStudent(new Student("Denis", "1", 6.8,2340));
                group.addStudent(new Student("Ksenya", "1", 8.2,840));

                Console.WriteLine("\nUnsorted students:");
                foreach (Student student in group.Students)
                {
                    Console.WriteLine(student);
                }
                
                group.sortStudents();
                
                Console.WriteLine("\nSorted students:");
                foreach (Student student in group.Students)
                {
                    Console.WriteLine(student);
                }

                //lab 14
                UP up = Lab14_15.methodUP;
                Console.WriteLine("\n14.1: " + Lab14_15.task1(up));
                
                UP lambdaUp = new UP((x) =>
                {
                    (double, double) tuple = (0, 0);
                    for (double i = -1; i <= 0; i += 0.2)
                    {
                        x += 0.2;
                        tuple = up(x);
                        Console.WriteLine(tuple);
                    }

                    return tuple;
                });
                Console.WriteLine("\nLambdaUP:");
                lambdaUp(-1);
            }
            catch (CustomException e)
            {
                Console.WriteLine(e.Message + "\n" + e.StackTrace);
            }
            Console.ReadLine();
        }
    }
}