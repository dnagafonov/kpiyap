using System;
using kpiyap.util;

namespace kpiyap
{
    interface IMyClonable:ICloneable
    {
        Counter myClone();
    }
    public class Counter:IMyClonable
    {
        public int Number { get; }
        public int Id { get; }
        public string Name { get; }
        
        public Counter(){}

        public Counter(int number, int id, string name)
        {
            if (number > 10)
            {
                int length = number.ToString().Length - 1;
                Number = number / ((int) Math.Pow(10, length));
            }
            else
                Number = number; 
            Id = id;
            Name = name;
        }
        public Counter myClone()
        {
            return new Counter(Number, Id, Name);
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}