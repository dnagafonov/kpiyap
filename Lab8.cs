using System;
using System.IO;

namespace kpiyap
{
    public class Lab8
    {
        public static void task()
        {
            var fileText = File.ReadAllText("C:/projects/Rider/KPyaP/song.txt");
            string[] arrayOfWords = fileText.Split(" ");
            Console.WriteLine(arrayOfWords.Length);
            int maxLenght = arrayOfWords[0].Length;
            string longestWord = "";
            for (int i = 1; i < arrayOfWords.Length; i++)
            {
                if (arrayOfWords[i].Length > maxLenght)
                {
                    maxLenght = arrayOfWords[i].Length;
                    longestWord = arrayOfWords[i];
                }
            }
            Console.WriteLine($"\nLongest word: {longestWord}\nWith length: {maxLenght}\n");
        }

        public static void test()
        {
            String path = "C:/projects/Rider/KPyaP/song.txt";
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                writer.Write("лох это =>");
                writer.Write("prp");
            }
        }
    }
}