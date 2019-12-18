using System;
using System.Collections.Generic;

namespace kpiyap
{
    public class Group
    {
        public List<Student> Students { get; }

        public Group()
        {
            fillStudents();
        }

        private void fillStudents()
        {
            Students.Add(new Student("Ivan", "1", 7.2,400));
            Students.Add(new Student("Konstantin", "1", 7.1,300));
            Students.Add(new Student("Nikita", "1", 6.2,200));
            Students.Add(new Student("Egor", "1", 3.2,360));
            Students.Add(new Student("Vorobey", "1", 8.2,340));
        }
    }

    public class Student
    {
        private double avarageMark;
        
        public string Name { get; }
        public string Group { get; }
        public int FamilyIncome { get; }

        public double AvarageMark
        {
            get { return avarageMark;}
            set
            {
                if (value > 0 && value <= 10)
                    avarageMark = value;
                else
                    throw new Exception("Invalid average mark");
            }
        }

        public override string ToString()
        {
            string str = string.Format("Name: {0}," +
                                       "Group: {1}" +
                                       "FamilyIncome: {2}" +
                                       "Average mark: {3}", Name, Group, FamilyIncome, AvarageMark);
            return str;
        }

        public Student(string name, string group, double avarageMark, int familyIncome)
        {
            Group = group;
            FamilyIncome = familyIncome;
            Name = name;
            AvarageMark = avarageMark;
        }
    }
}