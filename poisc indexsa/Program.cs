using System;

namespace lesson
{
    class Progpam
    {
        static int[] DoArray(int count)
        {
            int[] arr = new int[count];
            Random r = new Random();
            for (int i = 0; i < count; i++)
            {
                arr[i] = r.Next(-10, 10);
            }
            Console.Write("Получившийся массив: ");
            for (int i = 0; i < count; i++)
            {
                Console.Write(arr[i] + " ");
            }
            return arr;
        }
        static int FindNamber(int count, int symbolCount)
        {
            int [] arr = DoArray(count);
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] == symbolCount)
                {
                    return i;                    
                }
                
            }
              return -1;
                           
        }
        

        static void Main(string[] args)
        {
            Console.WriteLine("\nВведите количество элементов в массиве: ");
            int count =int.Parse( Console.ReadLine());


            Console.WriteLine("\nВведите число: ");
            int symbolCount = int.Parse(Console.ReadLine());

            int x = FindNamber(count, symbolCount);  
            if (x > 0)
                Console.WriteLine($"\nИндекс числа: {x}");

            else Console.WriteLine($"\nИндекс числа не найден в массиве");

           Console.ReadLine();

        }
    }

}