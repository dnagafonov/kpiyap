using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace kpiyap
{
    public class Lab22
    {
        private static void writeFile(string text)
        {
            try
            {
                StreamWriter sw = new StreamWriter("Test.txt");
                sw.WriteLine(text);
                sw.Close();
                Console.WriteLine("Done");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("finished");
            }
        }
        private static void readFile()
        {
            try 
            {
                StreamReader sr = new StreamReader("Test.txt");
                string line = sr.ReadLine();

                while (line != null) 
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }

                sr.Close();
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally 
            {
                Console.WriteLine("Executing finally block.");
            }       
        }

        public static void read()
        {
            Thread thread = new Thread(new ThreadStart(readFile));
            thread.Start();
        }
        
        public static void write(string s)
        {
            writeFile(s);
        }
    }
}