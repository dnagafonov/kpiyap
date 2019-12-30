using System;
using System.Collections.Generic;

namespace kpiyap.practice
{
    public class CarV1
    {
        private int id;
        private string brand;
        private string model;
        private double engine;
        private int doors;
        
        public string Brand
        {
            get => brand;
            set
            {
                if (brand.Length < 0)
                    throw new Exception("Error");
                brand = value;
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
        public string Model
        {
            get => model;
            set
            {
                if (model.Length < 0)
                    throw new Exception("Error");
                model = value;
            }
        }
        public double EngineVolume 
        {
            get => engine;
            set
            {
                if (engine < 1)
                    throw new Exception("Error");
                engine = value;
            }
        }
        public int AmountOfDoors 
        {
            get => doors;
            set
            {
                if (doors < 0)
                    throw new Exception("Error");
                doors = value;
            }
        }
        public List<CarV1> Array { get; }


        public CarV1()
        {
            Array = new List<CarV1>();
        }

        public CarV1(string brand)
        {
            Brand = brand;
        }
        
        public CarV1(int id, string brand)
        {
            Id = id;
            Brand = brand;
        }
        
        public CarV1( int id, string brand, double engineVolume)
        {
            Id = id;
            Brand = brand;
            EngineVolume = engineVolume;
        }
        
        public CarV1(int id, int amount, string model)
        {
            AmountOfDoors = amount;
            Id = id;
            Model = model;
        }

        public void sortByAmount()
        {
            Array.Sort((a,b) => a.AmountOfDoors.CompareTo(b.AmountOfDoors));
            foreach (CarV1 car in Array)
                Console.WriteLine(car + " ");
        }
        
        public void sortByModel()
        {
            Array.Sort((a,b) => String.Compare(a.Model, b.Model, StringComparison.Ordinal));
            foreach (CarV1 car in Array)
                Console.WriteLine(car + " ");
        }
        public void sortByBrand()
        {
            Array.Sort((a,b) => String.Compare(a.Brand, b.Brand, StringComparison.Ordinal));
            foreach (CarV1 car in Array)
                Console.WriteLine(car + " ");
        }
        public void sortByAmountOfDoors()
        {
            Array.Sort((a,b) => a.AmountOfDoors.CompareTo(b.AmountOfDoors));
            foreach (CarV1 car in Array)
                Console.WriteLine(car + " ");
        }
        public void sortById()
        {
            Array.Sort((a,b) => a.Id.CompareTo(b.Id));
            foreach (CarV1 car in Array)
                Console.WriteLine(car);
        }

        public override string ToString()
        {
            return String.Format("Id: {0}, Brand: {1}, Model: {2}, EngineVolume: {3}, AmountOfDoors: {4}", Id, Brand, Model, EngineVolume, AmountOfDoors);
        }
    }
}