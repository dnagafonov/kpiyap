using System;

namespace kpiyap
{
    public enum TriangleType
    {
        Null, Equilateral, Isosceles, Rectangular
    }
    public class Triangle
    {
        public int A { get; }
        public int B { get; }
        public int C { get; }
        public TriangleType Type { get; }

        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
            if ((int) Math.Pow(A, 2) + (int) Math.Pow(B, 2) == (int) Math.Pow(C, 2))
                Type = TriangleType.Rectangular;
            else if((int) Math.Pow(A, 2) + (int) Math.Pow(B, 2) > (int) Math.Pow(C, 2))
                Type = TriangleType.Isosceles;
            else if (A == B && A == C)
                Type = TriangleType.Equilateral;
            else
                throw new Exception("Can't to set type!!!");
        }

        public void getSquare()
        {
            double p = (A + B + C) / 2;
            Console.WriteLine("Square equal: " + Math.Sqrt(p * ((p - A) * (p - B) * (p - C))) );
        }

    }
}