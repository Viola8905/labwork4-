using System;

namespace лабка4._2_сейшарп
{
    class Program
    {
        static void Main(string[] args)
        {
            //Лабка 4 завдання 2
            Console.WriteLine("a=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b=");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("c=");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a >= 3 && a <= 9 && a >= b && a <= c)
            {
                Console.WriteLine("Належить");
            }
            else
            {
                Console.WriteLine("Не Належить");
            }

        }

    }
}