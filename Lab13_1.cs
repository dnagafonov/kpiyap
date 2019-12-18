using System;

namespace kpiyap
{
    public enum TriangleType
    {
         Equilateral, Isosceles, Rectangular
    }
    public class Triangle
    {
        private TriangleType type;
        public int A { get; }
        public int B { get; }
        public int C { get; }

        public TriangleType Type;

        public Triangle(int a, int b, int c)
        {
            if (c < 0 || b < 0 || a < 0)
                throw new Exception("negative");
            else
            {
                A = a;
                B = b;
                C = c;
            }

            if ((int) Math.Pow(A, 2) + (int) Math.Pow(B, 2) == (int) Math.Pow(C, 2))
                Type = TriangleType.Rectangular;
            else if((int) Math.Pow(A, 2) + (int) Math.Pow(B, 2) > (int) Math.Pow(C, 2))
                Type = TriangleType.Isosceles;
            else if (A == B && A == C)
                Type = TriangleType.Equilateral;
            else
                throw new Exception("Nonexistent triangle");
        }

        public void getSquare()
        {
            double p = (A + B + C) * 0.5;
            Console.WriteLine("Square equal: " + Math.Sqrt(p * ((p - A) * (p - B) * (p - C))) );
        }

    }
}