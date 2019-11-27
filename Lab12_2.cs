using System;

namespace kpiyap
{
    public class Counter
    {
        private int number { get; set; }
        private int id { get; set; }
        private string name { get; set; }
        
        public Counter(){}

        public Counter(int number, int id, string name)
        {
            if (number > 10)
            {
                int length = number.ToString().Length - 1;
                this.number = number / ((int) Math.Pow(10, length));
            }
            else
                this.number = number; 
            this.id = id;
            this.name = name;
        }

        public int getId()
        {
            return number;
        }
                
    }
}