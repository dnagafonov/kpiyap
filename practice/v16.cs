using System;
using System.Collections.Generic;
namespace kpiyap.practice
{
    public class Human
    {
        private int id;
        private string name;
        private bool married;
        private bool hasHasWork;
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
        public bool Married
        {
            get => married;
            set => married = value;
        }
        public bool HasWork
        {
            get => hasHasWork;
            set => hasHasWork = value;
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
        public List<Human> Array { get; }


        public Human()
        {
            Array = new List<Human>();
        }

        public Human(string name)
        {
            Name = name;
        }
        
        public Human(int id, bool married)
        {
            Id = id;
            Married = married;
        }
        
        public Human(int id, string name, bool married)
        {
            Id = id;
            Married = married;
            Name = name;
        }
        
        public Human(int id, string name, bool hasWork, int salary)
        {
            Salary = salary;
            Name = name;
            Id = id;
            HasWork = hasWork;
        }

        public void sortBySalary()
        {
            Array.Sort((a,b) => a.Salary.CompareTo(b.Salary));
            foreach (Human el in Array)
                Console.WriteLine(el);
        }
        
        public void sortByName()
        {
            Array.Sort((a,b) => String.Compare(a.Name, b.Name, StringComparison.Ordinal));
            foreach (Human el in Array)
                Console.WriteLine(el);
        }
        public void sortByHasWork()
        {
            Array.Sort((a,b) => a.HasWork.CompareTo(b.HasWork));
            foreach (Human el in Array)
                Console.WriteLine(el);
        }
        public void sortByMarried()
        {
            Array.Sort((a,b) => a.Married.CompareTo(b.Married));
            foreach (Human el in Array)
                Console.WriteLine(el);
        }
        public void sortById()
        {
            Array.Sort((a,b) => a.Id.CompareTo(b.Id));
            foreach (Human el in Array)
                Console.WriteLine(el);
        }

        public override string ToString()
        {
            return String.Format("Id: {0}, Married: {1}, Name: {2}, HasWork: {3}, Salary: {4}", Id, Married, Name, HasWork, Salary);
        }
    }
}