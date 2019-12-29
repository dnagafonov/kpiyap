﻿using System;
using System.Collections.Generic;
namespace kpiyap.practice
{
    public class Employee
    {
        public string Name { get; }
        public int Id { get; }
        public int Experience { get; }
        public double WorkHours { get; }
        public int Salary { get; }
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