using System;
using System.Collections.Generic;
namespace kpiyap.practice
{
    public class Drink
    {
        private int quantity;
        private string name;
        private int calories;
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
        public int Calories
        {
            get => calories;
            set
            {
                if (value < 0)
                    throw new Exception("Error");
                calories = value;
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
        public List<Drink> Array { get; }


        public Drink()
        {
            Array = new List<Drink>();
        }

        public Drink(string name)
        {
            Name = name;
        }
        
        public Drink(int quantity, int calories)
        {
            Quantity = quantity;
            Calories = calories;
        }
        
        public Drink(int quantity, string name, int calories)
        {
            Quantity = quantity;
            Calories = calories;
            Name = name;
        }
        
        public Drink(int quantity, string name, int weight, int price)
        {
            Price = price;
            Name = name;
            Quantity = quantity;
            Weight = weight;
        }

        public void sortByPrice()
        {
            Array.Sort((a,b) => a.Price.CompareTo(b.Price));
            foreach (Drink el in Array)
                Console.WriteLine(el);
        }
        
        public void sortByName()
        {
            Array.Sort((a,b) => String.Compare(a.Name, b.Name, StringComparison.Ordinal));
            foreach (Drink el in Array)
                Console.WriteLine(el);
        }
        public void sortByQuantity()
        {
            Array.Sort((a,b) => a.Quantity.CompareTo(b.Quantity));
            foreach (Drink el in Array)
                Console.WriteLine(el);
        }
        public void sortByWeight()
        {
            Array.Sort((a,b) => a.Weight.CompareTo(b.Weight));
            foreach (Drink el in Array)
                Console.WriteLine(el);
        }
        public void sortByCalories()
        {
            Array.Sort((a,b) => a.Calories.CompareTo(b.Calories));
            foreach (Drink el in Array)
                Console.WriteLine(el);
        }

        public override string ToString()
        {
            return String.Format("Quantity: {0}, Calories: {1}, Name: {2}, Weight: {3}, Price: {4}", Quantity, Calories, Name, Weight, Price);
        }
    }
}