using System;

namespace lesson
{
    class Progpam
    {
        static int DoArray(int count, int symbolCount)
        {
            int x = -1;
            int[] arr = new int[count];
            Random r = new Random();
            for (int i = 0; i < count; i++)
            {
                arr[i] = r.Next(-10,10);
            }
            Console.Write("Получившийся массив: ");
            for (int i = 0; i < count; i++)
            {
                Console.Write(arr[i]+" ");
            }
            for (int i = 0; i < count; i++)
            {
                if (arr[i] == symbolCount)
                {
                    x = i;
                    break;
                }
                else x = -1;
            }
              return x;
                           
        }
        

        static void Main(string[] args)
        {
            Console.WriteLine("\nВведите количество элементов в массиве: ");
            int count =int.Parse( Console.ReadLine());


            Console.WriteLine("\nВведите число: ");
            int symbolCount = int.Parse(Console.ReadLine());

            
            Console.WriteLine($"\nИндекс числа: {DoArray(count, symbolCount)}");
            //Console.WriteLine(DoArray(count, symbolCount));
            

            Console.ReadLine();

        }
    }

}