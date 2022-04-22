using System;

namespace lesson
{
    class Progpam
    {
        static void Print(char symbol, uint symbolCount)
        {
            for (int i = 0; i < symbolCount; i++) Console.Write(symbol);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ: ");
            char symbol = Console.ReadKey().KeyChar;

            Console.WriteLine("\nВведите число: ");
            uint symbolCount = uint.Parse(Console.ReadLine());

            Print(symbol, symbolCount);

            Console.ReadLine();

        }
    }

}