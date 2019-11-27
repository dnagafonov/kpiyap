using System;

namespace kpiyap
{
    public class Y:X
    {
        private int y { get; }
        public Y(){}

        public Y(int x1, int x2, int y) : base(x1, x2)
        {
            this.y = y;
        }

        public void run()
        {
            Console.WriteLine("Sum: " + (x1 + x2 - y));
        }
    }
    public class X
    {
        protected int x1 { get; }
        protected int x2 { get; }
        
        protected X(){}
        protected X(int x1, int x2)
        {
            this.x1 = x1;
            this.x2 = x2;
        }
        
    }
    
    public abstract class Figure : Y
    {
        
    }
}