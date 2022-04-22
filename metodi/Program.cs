﻿using System;

namespace lesson
{
    class Progpam
    {
        static void Print(string symbol, uint symbolCount )
        {
            for (int i = 0; i < symbolCount; i++) Console.Write(symbol);
        }
        
        static void Main(string[] args)
       {
            Console.WriteLine("Введите символ: ");
            string symbol = Console.ReadLine();

            Console.WriteLine("Введите число: ");
            uint symbolCount = uint.Parse(Console.ReadLine());

            Print(symbol, symbolCount);

            Console.ReadLine();

        }
    }

}