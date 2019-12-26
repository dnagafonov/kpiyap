using System;
using System.IO;
using System.Xml.Serialization;

namespace kpiyap
{
    
    public class Lab10_1
    {
        private int m;
        private int n;
        private int sum = 0;
        private int mul = 1;
        
       [XmlAttribute]
        public int M 
        {
            set => m = value;
        }

        public int N
        {
            set => n = value;
        }
        public int Sum { get; set; }
        public int Mul { get; set; }

        public Lab10_1() {}
        public Lab10_1(int m, int n)
        {
            M = m;
            N = n;
        }
        
        public void getSum()
        {
            for (int i = m; i < n; i += m)
            {
                Sum += 2 * i;
            }

            Console.WriteLine("Sum: " + sum);
        }

        public void getMul()
        {
            for (int i = m; i < n; i += m)
            {
                Mul *= 2 * i;
            }

            Console.WriteLine("Mul: " + mul+ "\n");
        }

        public void Save(string fileName)
        {
            using (var stream = new FileStream(fileName, FileMode.Create))
            {
                var xmlSerializer = new XmlSerializer(typeof(Lab10_1));
                xmlSerializer.Serialize(stream, this);
            }
        }
    }
}