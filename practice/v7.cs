using System;
using System.Collections.Generic;

namespace kpiyap.practice
{
    public class Computer
    {
        private int id;
        private string userName;
        private int ramCapacity;
        private string motherboard;
        private string processor;
        public string UserName
        {
            get => userName;
            set
            {
                if (userName.Length < 0)
                    throw new Exception("Error");
                userName = value;
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
        public int RAMCapacity
        {
            get => ramCapacity;
            set
            {
                if (ramCapacity < 0)
                    throw new Exception("Error");
                ramCapacity = value;
            }
        }
        public string Motherboard 
        {
            get => motherboard;
            set
            {
                if (motherboard.Length < 0)
                    throw new Exception("Error");
                motherboard = value;
            }
        }
        public string Processor
        {
            get => processor;
            set
            {
                if (processor.Length < 0)
                    throw new Exception("Error");
                processor = value;
            }
        }
        public List<Computer> Array { get; }


        public Computer()
        {
            Array = new List<Computer>();
        }

        public Computer(string userName)
        {
            UserName = userName;
        }
        
        public Computer(int id, int ramCapacity)
        {
            Id = id;
            RAMCapacity = ramCapacity;
        }
        
        public Computer(int id, string userName, int ramCapacity)
        {
            Id = id;
            RAMCapacity = ramCapacity;
            UserName = userName;
        }
        
        public Computer(int id, string userName, string motherboard, string processor)
        {
            Processor = processor;
            UserName = userName;
            Id = id;
            Motherboard = motherboard;
        }

        public void sortByProcessor()
        {
            Array.Sort((a,b) => String.Compare(a.Processor, b.Processor, StringComparison.Ordinal));
            foreach (Computer el in Array)
                Console.WriteLine(el);
        }
        
        public void sortByUserName()
        {
            Array.Sort((a,b) => String.Compare(a.UserName, b.UserName, StringComparison.Ordinal));
            foreach (Computer el in Array)
                Console.WriteLine(el);
        }
        public void sortByRAM()
        {
            Array.Sort((a,b) => a.RAMCapacity.CompareTo(b.RAMCapacity));
            foreach (Computer el in Array)
                Console.WriteLine(el);
        }
        public void sortByExperience()
        {
            Array.Sort((a,b) => String.Compare(a.Motherboard, b.Motherboard, StringComparison.Ordinal));
            foreach (Computer el in Array)
                Console.WriteLine(el);
        }
        public void sortById()
        {
            Array.Sort((a,b) => a.Id.CompareTo(b.Id));
            foreach (Computer el in Array)
                Console.WriteLine(el);
        }

        public override string ToString()
        {
            return String.Format("Id: {0}, RAMCapacity: {1}, UserName: {2}, Motherboard: {3}, Processor: {4}", Id, RAMCapacity, UserName, Motherboard, Processor);
        }
    }
}