using System;
using System.Collections.Generic;
using System.Linq;

namespace kpiyap
{
    public class Buyer
    {
        public string name { get; }
        public string adress { get; }
        public int discount { get; }

        public Buyer(string name, string adress, int discount)
        {
            this.name = name;
            this.adress = adress;
            this.discount = discount;
        }
    }
    public struct Lab9
    {
        private static Dictionary<int, Buyer> buyers = new Dictionary<int, Buyer>();
        
        private void fillBuyers()
        {
            buyers.Add(0, new Buyer("Sviridenko I.V.", "Kukushkina 54", 10));    
            buyers.Add(1, new Buyer("Molcov I.K.", "Zmeina 4", 15));
            buyers.Add(2, new Buyer("Sparrow E.V.", "Serebro 5", 17));
            buyers.Add(3, new Buyer("Dyachenko I.D.", "Punina 57", 18));    
            buyers.Add(4, new Buyer("Lapovskiy I.V.", "Schukina 24", 30));    
            buyers.Add(5, new Buyer("Sviridenko I.V.", "Kukushkina 54", 5));
        }

        public void getNewBuyers()
        {
            fillBuyers();
            Dictionary<int, Buyer> res = new Dictionary<int, Buyer>(buyers);
            foreach (var i in buyers)
            {
                foreach (var j in buyers)
                {
                    if ((i.Value.name == j.Value.name) && (i.Key != j.Key) && (i.Value.adress == j.Value.adress))
                    {
                        res.Remove(i.Key);
                    }
                }
            }
            Console.WriteLine("\n");
            foreach (var VARIABLE in res)
            {
                Console.WriteLine(VARIABLE.Value.name);
            }

        }
    }
}