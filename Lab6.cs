using System;

namespace kpiyap
{
    public class Emploee
    {
        public string name { get; private set; }
        public DateTime time { get; private set; }
        public int age { get; private set; }
        public void setEmploee(string name, DateTime time, int age)
        {
            this.name = name;
            this.time = time;
            this.age = age;
        }
    }
    public class Lab6
    {
        private Emploee[] emploees = new Emploee[3];
        private DateTime nowTime = DateTime.Now;
        public void setEmploees()
        {
            Emploee e1 = new Emploee();
            e1.setEmploee("Stiven", new DateTime(2017, 08, 01), 22);
            emploees[0] = e1;
            Emploee e2 = new Emploee();
            e2.setEmploee("Nade", new DateTime(2016, 08, 01), 34);
            emploees[1] = e2;
            Emploee e3 = new Emploee();
            e3.setEmploee("Jane", new DateTime(2011, 08, 01), 33);
            emploees[2] = e3;
        }

        private int findYoungest()
        {
            int minAge = 0;
            for (int i = 0; i < emploees.Length; i++)
            {
                if (emploees[i].age < minAge)
                {
                    minAge = i;
                }
            }
            return minAge;
        }

        public void getExperience()
        {
            setEmploees();
            int index = findYoungest();
            Console.WriteLine("Стаж работы " + this.emploees[index].name + " состовляет " + (this.nowTime.Year - emploees[index].time.Year) + " года");
        }
    }
}