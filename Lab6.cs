using System;

namespace kpiyap
{
    public class Lab6
    {
        private Emploee[] emploees = new Emploee[3];
        private DateTime nowTime = DateTime.Now;
        public void setEmploees()
        {
            Emploee e1 = new Emploee("Stiven", new DateTime(2017, 08, 01), 22);
            emploees[0] = e1;
            Emploee e2 = new Emploee("Nade", new DateTime(2016, 08, 01), 34);
            emploees[1] = e2;
            Emploee e3 = new Emploee("Jane", new DateTime(2011, 08, 01), 33);
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

        public static void task2(string name, int age, int mark)
        {
            string str = String.Format("{0}, age-{1} years, mark – {2}", name, age, mark);
            Console.WriteLine(str);
        }
    }
}