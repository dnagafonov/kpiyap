using System;
using System.Collections.Generic;
namespace kpiyap.practice
{
    public class Bird
    {
        private int id;
        private string family;
        private bool plumage;
        private bool infected;
        private int weight;
        public string Family
        {
            get => family;
            set
            {
                if (value.Length < 0)
                    throw new Exception("Error");
                family = value;
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
        public bool Plumage
        {
            get => plumage;
            set => plumage = value;
        }
        public bool Infected
        {
            get => infected;
            set => infected = value;
        }
        public int Weight
        {
            get => weight;
            set
            {
                if (value < 0)
                    throw new Exception("Error");
                weight = value;
            }
        }
        public List<Bird> Array { get; }


        public Bird()
        {
            Array = new List<Bird>();
        }

        public Bird(string family)
        {
            Family = family;
        }
        
        public Bird(int id, bool plumage)
        {
            Id = id;
            Plumage = plumage;
        }
        
        public Bird(int id, string family, bool plumage)
        {
            Id = id;
            Plumage = plumage;
            Family = family;
        }
        
        public Bird(int id, string family, bool infected, int weight)
        {
            Weight = weight;
            Family = family;
            Id = id;
            Infected = infected;
        }

        public void sortByWeight()
        {
            Array.Sort((a,b) => a.Weight.CompareTo(b.Weight));
            foreach (Bird el in Array)
                Console.WriteLine(el);
        }
        
        public void sortByFamily()
        {
            Array.Sort((a,b) => String.Compare(a.Family, b.Family, StringComparison.Ordinal));
            foreach (Bird el in Array)
                Console.WriteLine(el);
        }
        public void sortByInfected()
        {
            Array.Sort((a,b) => a.Infected.CompareTo(b.Infected));
            foreach (Bird el in Array)
                Console.WriteLine(el);
        }
        public void sortByPlumage()
        {
            Array.Sort((a,b) => a.Plumage.CompareTo(b.Plumage));
            foreach (Bird el in Array)
                Console.WriteLine(el);
        }
        public void sortById()
        {
            Array.Sort((a,b) => a.Id.CompareTo(b.Id));
            foreach (Bird el in Array)
                Console.WriteLine(el);
        }

        public override string ToString()
        {
            return String.Format("Id: {0}, Plumage: {1}, Family: {2}, Infected: {3}, Weight: {4}", Id, Plumage, Family, Infected, Weight);
        }
    }
}