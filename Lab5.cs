using System;
using System.Text;

namespace kpiyap
{
    public class Lab5
    {
        public static void task1(int n, char c1, char c2)
        {
            string StrRes = "";
            string strC1 = c1.ToString();
            string strC2 = c2.ToString();
            StrRes += strC1;
            
            char[] CharRes = new char[n + 1];
            
            StringBuilder stringBuilder = new StringBuilder(n);
            stringBuilder.Append(c1);

            if (n % 2 == 0)
            {
                for (int i = 1; i != n + 1; i++)
                {
                    if (i % 2 == 0)
                    {
                        CharRes[i] = c2;
                    }

                    if (i % 2 != 0)
                    {
                        CharRes[i] = c1;
                    }
                }
                for (int i = 0; i != n - 1; i++)
                {
                    if (i % 2 == 0)
                    {
                        stringBuilder.Append(c2);
                        StrRes += strC2;
                    }

                    if (i % 2 != 0)
                    {
                        stringBuilder.Append(c1);
                        StrRes += strC1;
                    }
                }

                Console.WriteLine("Char:   " + new string(CharRes));
                Console.WriteLine("Builder: " + stringBuilder);
                Console.WriteLine("String:  " + StrRes);

            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}