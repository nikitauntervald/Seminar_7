using System;
class Program
{
    
        static int Ackermann(int m, int n)
        {
            if (m == 0) return n + 1;
            if (m > 0 && n == 0) return Ackermann(m - 1, 1);
            if (m > 0 && n > 0) return Ackermann(m - 1, Ackermann(m, n - 1));
            return Ackermann(m, n);
        }


        private static void Main(string[] args)
        {

            int result = Ackermann(2, 1);
            Console.WriteLine(result);
        }
    
}
