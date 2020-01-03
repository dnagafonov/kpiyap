using System;
using System.Collections.Generic;
namespace kpiyap.practice
{
    public class Employee
    {
        private int id;
        private string name;
        private int experience;
        private double hours;
        private int salary;
        public string Name
        {
            get => name;
            set
            {
                if (value.Length < 0)
                    throw new Exception("Error");
                name = value;
            }
        }
        public int Id
        {
            get => id;
            set
            {
                if (value < 0)
                    throw new Exception("Error");
                id = value;
            }
        }
        public int Experience
        {
            get => experience;
            set
            {
                if (value < 0)
                    throw new Exception("Error");
                experience = value;
            }
        }
        public double WorkHours
        {
            get => hours;
            set
            {
                if (value < 0)
                    throw new Exception("Error");
                hours = value;
            }
        }
        public int Salary
        {
            get => salary;
            set
            {
                if (value < 0)
                    throw new Exception("Error");
                salary = value;
            }
        }
        public List<Employee> Array { get; }


        public Employee()
        {
            Array = new List<Employee>();
        }

        public Employee(string name)
        {
            Name = name;
        }
        
        public Employee(int id, int experience)
        {
            Id = id;
            Experience = experience;
        }
        
        public Employee(int id, string name, int experience)
        {
            Id = id;
            Experience = experience;
            Name = name;
        }
        
        public Employee(int id, string name, int workHours, int salary)
        {
            Salary = salary;
            Name = name;
            Id = id;
            WorkHours = workHours;
        }

        public void sortBySalary()
        {
            Array.Sort((a,b) => a.Salary.CompareTo(b.Salary));
            foreach (Employee el in Array)
                Console.WriteLine(el);
        }
        
        public void sortByName()
        {
            Array.Sort((a,b) => String.Compare(a.Name, b.Name, StringComparison.Ordinal));
            foreach (Employee el in Array)
                Console.WriteLine(el);
        }
        public void sortByWorkHours()
        {
            Array.Sort((a,b) => a.WorkHours.CompareTo(b.WorkHours));
            foreach (Employee el in Array)
                Console.WriteLine(el);
        }
        public void sortByExperience()
        {
            Array.Sort((a,b) => a.Experience.CompareTo(b.Experience));
            foreach (Employee el in Array)
                Console.WriteLine(el);
        }
        public void sortById()
        {
            Array.Sort((a,b) => a.Id.CompareTo(b.Id));
            foreach (Employee el in Array)
                Console.WriteLine(el);
        }

        public override string ToString()
        {
            return String.Format("Id: {0}, Experience: {1}, Name: {2}, WorkHours: {3}, Salary: {4}", Id, Experience, Name, WorkHours, Salary);
        }
    }
}