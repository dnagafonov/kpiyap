﻿using System;
using System.Collections.Generic;
namespace kpiyap.practice
{
    public class Vegetable
    {
        private int quantity;
        private string name;
        private int countOfSeeds;
        private double weight;
        private int price;
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
        public int Quantity
        {
            get => quantity;
            set
            {
                if (value < 0)
                    throw new Exception("Error");
                quantity = value;
            }
        }
        public int CountOfSeeds
        {
            get => countOfSeeds;
            set
            {
                if (value < 0)
                    throw new Exception("Error");
                countOfSeeds = value;
            }
        }
        public double Weight
        {
            get => weight;
            set
            {
                if (value < 0)
                    throw new Exception("Error");
                weight = value;
            }
        }
        public int Price
        {
            get => price;
            set
            {
                if (value < 0)
                    throw new Exception("Error");
                price = value;
            }
        }
        public List<Vegetable> Array { get; }


        public Vegetable()
        {
            Array = new List<Vegetable>();
        }

        public Vegetable(string name)
        {
            Name = name;
        }
        
        public Vegetable(int quantity, int countOfSeeds)
        {
            Quantity = quantity;
            CountOfSeeds = countOfSeeds;
        }
        
        public Vegetable(int quantity, string name, int countOfSeeds)
        {
            Quantity = quantity;
            CountOfSeeds = countOfSeeds;
            Name = name;
        }
        
        public Vegetable(int quantity, string name, int weight, int price)
        {
            Price = price;
            Name = name;
            Quantity = quantity;
            Weight = weight;
        }

        public void sortByPrice()
        {
            Array.Sort((a,b) => a.Price.CompareTo(b.Price));
            foreach (Vegetable el in Array)
                Console.WriteLine(el);
        }
        
        public void sortByName()
        {
            Array.Sort((a,b) => String.Compare(a.Name, b.Name, StringComparison.Ordinal));
            foreach (Vegetable el in Array)
                Console.WriteLine(el);
        }
        public void sortByQuantity()
        {
            Array.Sort((a,b) => a.Quantity.CompareTo(b.Quantity));
            foreach (Vegetable el in Array)
                Console.WriteLine(el);
        }
        public void sortByWeight()
        {
            Array.Sort((a,b) => a.Weight.CompareTo(b.Weight));
            foreach (Vegetable el in Array)
                Console.WriteLine(el);
        }
        public void sortByCountOfSeeds()
        {
            Array.Sort((a,b) => a.CountOfSeeds.CompareTo(b.CountOfSeeds));
            foreach (Vegetable el in Array)
                Console.WriteLine(el);
        }

        public override string ToString()
        {
            return String.Format("Quantity: {0}, CountOfSeeds: {1}, Name: {2}, Weight: {3}, Price: {4}", Quantity, CountOfSeeds, Name, Weight, Price);
        }
    }
}