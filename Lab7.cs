using System;
using System.Collections.Generic;

namespace kpiyap
{
    public class Lab7
    {
        Dictionary<int, Emploee> emploees = new Dictionary<int, Emploee>();
        public void setEmploees()
        {
            Emploee e1 = new Emploee("Stiven", new DateTime(2019, 08, 10, 6, 10, 0), 22);
            emploees.Add(7,e1);
            Emploee e2 = new Emploee("Nade", new DateTime(2019, 08, 01,7,0,8), 34);
            emploees[1] = e2;
            Emploee e3 = new Emploee("Jane", new DateTime(2019, 08, 01,16,0,3), 33);
            emploees[2] = e3;
            Emploee e4 = new Emploee("Vova", new DateTime(2019, 08, 01,13,55,3), 33);
            emploees[3] = e4;
            Emploee e5 = new Emploee("Jukov", new DateTime(2019, 08, 01,8,0,0), 33);
            emploees[4] = e5;
        }

        public void getWorkingShift()
        {
            int id = 0;
            Dictionary<int, Emploee> first = new Dictionary<int, Emploee>();
            Dictionary<int, Emploee> second = new Dictionary<int, Emploee>();
            setEmploees();
            foreach (var emploee in emploees)
            {
                if (emploee.Value.time.Hour >= 7 && emploee.Value.time.Hour <= 14)
                {
                    first.Add(id++, new Emploee(emploee.Value.name, emploee.Value.time, emploee.Value.age));
                    Console.WriteLine(emploee.Value.name , emploee.Key);
                }
                if (emploee.Value.time.Hour >= 15 && emploee.Value.time.Hour <= 20)
                {
                    second.Add(id++, new Emploee(emploee.Value.name, emploee.Value.time, emploee.Value.age));
                }
            }
        }
    }
}