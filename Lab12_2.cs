using System;

namespace kpiyap
{
    interface IMyClonable
    {
        Counter myClone();
    }
    class Counter:IMyClonable
    {
        private int number;
        private int id;
        private string name;

        public int Number { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        
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
    }
}