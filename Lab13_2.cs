using System;
using System.Collections.Generic;

namespace kpiyap
{
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {
        }
    }
    public class Group
    {
        public List<Student> Students { get; }

        private int min;
        public int Min
        {
            get { return min; }
            set
            {
                if (value <= 1000 && value > 0)
                    min = value;
                else
                    throw new CustomException("Invalid min value");
            }
        }

        public Group()
        {
            Students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void sortStudents()
        {
            int count = 0;
            Students.Sort(lessFamilyIncome);
            Students.Sort(greaterAverageMark);
        }

        private int greaterAverageMark(Student a, Student b)
        {
            if (a.AverageMark > b.AverageMark)
                return 1;
            return 0;
        }
        private int lessFamilyIncome(Student a, Student b)
        {
            if (a.FamilyIncome * 2 >= Min)
                return 1;
            return -1;
        }
    }

    public class Student
    {
        private double averageMark;
        
        public string Name { get; }
        public string Group { get; }
        public int FamilyIncome { get; }

        public double AverageMark
        {
            get { return averageMark;}
            set
            {
                if (value > 0 && value <= 10)
                    averageMark = value;
                else
                    throw new CustomException("Invalid average mark");
            }
        }

        public Student(string name, string group, double averageMark, int familyIncome)
        {
            Group = group;
            FamilyIncome = familyIncome;
            Name = name;
            AverageMark = averageMark;
        }
        
        public override string ToString()
        {
            string str = string.Format("Name:{0}   " +
                                       "Group:{1}   " +
                                       "FamilyIncome:{2}   " +
                                       "Average mark:{3}   ", Name, Group, FamilyIncome, AverageMark);
            return str;
        }
    }
}