using System;
class Program
{
    static void Main()
    {
        int[] CreateRandomArray(int size, int min, int max)
        {
            Random rnd = new Random();
            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(min, max + 1);
            }
            return array;
        }


        
        void ShowInvertArray(int[] array)
        {
            if (array.Length == 0)
                return;
            ShowInvertArray(array.Skip(1).ToArray());
            if (array.Length > 1)
                Console.Write(", ");
            Console.Write(array[0]);
        }

        
        void ShowInvertArrayPosMethod(int[] array, int pos)
        {
            if (pos >= array.Length)
                return;
            ShowInvertArrayPosMethod(array, pos + 1);
            if (pos < array.Length - 1)
                Console.Write(", ");
            Console.Write(array[pos]);
        }



        Console.Clear();
        Console.Write("Enter array size: ");
        int size = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Enter min: ");
        int min = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Enter max: ");
        int max = Convert.ToInt32(Console.ReadLine());

        int[] array = CreateRandomArray(size, min, max);
        Console.WriteLine($"{String.Join(", ", array)}");   


        ShowInvertArrayPosMethod(array, 0);
        Console.WriteLine();
        ShowInvertArray(array);
    }
}