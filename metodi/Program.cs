using System;

namespace lesson
{
    class Progpam
    {
        


       static void Main(string[] args)
       {
            Console.WriteLine("Введите символ");
            string simvol = Console.ReadLine();
            Console.WriteLine("Введите количество символов");
            int namber = int.Parse(Console.ReadLine());

            for (int i = 0; i < namber; i++) Console.Write(simvol);

            Console.ReadLine();

        }
    }

}