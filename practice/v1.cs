using System;
using System.Collections.Generic;

namespace kpiyap.practice
{
    public class CarV1
    {
        public string Brand { get; }
        public int Id { get; }
        public string Model { get; }
        public double EngineVolume { get; }
        public int AmountOfDoors { get; }
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