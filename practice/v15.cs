using System;
using System.Collections.Generic;
namespace kpiyap.practice
{
    public class Food
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
                if (name.Length < 0)
                    throw new Exception("Error");
                name = value;
            }
        }
        public int Quantity
        {
            get => quantity;
            set
            {
                if (quantity < 0)
                    throw new Exception("Error");
                quantity = value;
            }
        }
        public int Calories
        {
            get => calories;
            set
            {
                if (calories < 0)
                    throw new Exception("Error");
                calories = value;
            }
        }
        public double Weight
        {
            get => weight;
            set
            {
                if (weight < 0)
                    throw new Exception("Error");
                weight = value;
            }
        }
        public int Price
        {
            get => price;
            set
            {
                if (price < 0)
                    throw new Exception("Error");
                price = value;
            }
        }
        public List<Food> Array { get; }


        public Food()
        {
            Array = new List<Food>();
        }

        public Food(string name)
        {
            Name = name;
        }
        
        public Food(int quantity, int calories)
        {
            Quantity = quantity;
            Calories = calories;
        }
        
        public Food(int quantity, string name, int calories)
        {
            Quantity = quantity;
            Calories = calories;
            Name = name;
        }
        
        public Food(int quantity, string name, int weight, int price)
        {
            Price = price;
            Name = name;
            Quantity = quantity;
            Weight = weight;
        }

        public void sortByPrice()
        {
            Array.Sort((a,b) => a.Price.CompareTo(b.Price));
            foreach (Food el in Array)
                Console.WriteLine(el);
        }
        
        public void sortByName()
        {
            Array.Sort((a,b) => String.Compare(a.Name, b.Name, StringComparison.Ordinal));
            foreach (Food el in Array)
                Console.WriteLine(el);
        }
        public void sortByQuantity()
        {
            Array.Sort((a,b) => a.Quantity.CompareTo(b.Quantity));
            foreach (Food el in Array)
                Console.WriteLine(el);
        }
        public void sortByWeight()
        {
            Array.Sort((a,b) => a.Weight.CompareTo(b.Weight));
            foreach (Food el in Array)
                Console.WriteLine(el);
        }
        public void sortByCalories()
        {
            Array.Sort((a,b) => a.Calories.CompareTo(b.Calories));
            foreach (Food el in Array)
                Console.WriteLine(el);
        }

        public override string ToString()
        {
            return String.Format("Quantity: {0}, Calories: {1}, Name: {2}, Weight: {3}, Price: {4}", Quantity, Calories, Name, Weight, Price);
        }
    }
}