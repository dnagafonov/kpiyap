using System;
namespace kpiyap
{
    public class Emploee
    {
        public string name { get; private set; }
        public DateTime time { get; private set; }
        public int age { get; private set; }

        public Emploee(string name, DateTime time, int age)
        {
            this.name = name;
            this.time = time;
            this.age = age;
        }
    }
}