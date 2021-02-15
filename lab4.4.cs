using System;

namespace лабка_4._4_сейшарп
{
    class Program
    {
        static void Main(string[] args)
        {
            //лабка 4 завдання 4
            Console.WriteLine("х=");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y=");
            double y = Convert.ToDouble(Console.ReadLine());
            const double e = 2.7;
            if (y == x)
            {
                double z = y * x;
                Console.WriteLine("z={0}", z);
            }
            else if (y < x)
            {
                double z = y * (Math.Pow(e, x));
                Console.WriteLine("z={0}", z);
            }
            else if (x<y)
            {
                double z = x * (Math.Pow(e, y));
                Console.WriteLine("z={0}", z);
            }
            else
            {
                Console.WriteLine("no match");
                
            }
            
        }
    }
}
