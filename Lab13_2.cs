using System;
using System.Collections.Generic;
using System.Linq;

namespace kpiyap
{
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message) {}
    }
    public class Group
    {
        public List<Student> Students { get; private set; }

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

        public void addStudent(Student student)
        {
            Students.Add(student);
        }

        public void sortStudents()
        {
            List<Student> sortedStudentsGreatMark = new List<Student>();
            List<Student> sortedStudents = new List<Student>();
            
            Students.Sort((s1, s2) => s1.FamilyIncome.CompareTo(s2.FamilyIncome));
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].FamilyIncome * 2 < Min)
                    sortedStudents.Add(Students[i]);
            }
            sortedStudents.Sort((s1, s2) => s1.FamilyIncome.CompareTo(s2.FamilyIncome));
            
            for (int i = sortedStudents.Count; i < Students.Count; i++)
                sortedStudentsGreatMark.Add(Students[i]);
            sortedStudentsGreatMark.Sort((s1, s2) => s2.AverageMark.CompareTo(s1.AverageMark));

            Students = new List<Student>(sortedStudents.Union(sortedStudentsGreatMark));
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