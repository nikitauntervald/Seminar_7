using System;
class Program
{      
    static void LineNumbers(int m, int n)
        {
            if (m <= n)
            {
                LineNumbers(m, n - 1);
                Console.Write(n + " ");
            }
        }
        private static void Main(string[] args)
        {

            LineNumbers(12, 78);
        }
    }
