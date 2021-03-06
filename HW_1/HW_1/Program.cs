using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            const double Pi = 3.14;

            for (int i = 0; i < 3; i++)
            {
                try
                {
                    Console.Write("Введите значение радиуса круга ->");
                    double r = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите значение стороны квадрата ->");
                    double s = Convert.ToDouble(Console.ReadLine());

                    double ca = Pi * r * r;
                    double sa = s * s;

                    Console.WriteLine("Площадь круга равна {0}", Math.Round(ca, 2));
                    Console.WriteLine("Площадь квадрата равна {0}", Math.Round(sa, 2));
                    Console.ReadKey();
                }
                catch
                {
                    i = i++;
                }
            }

            Random rnd = new Random();
            double r1 = (rnd.NextDouble() * (5 - 0.5)) + 0.5;
            double s1 = (rnd.NextDouble() * (5 - 0.5)) + 0.5;
            double ca1 = Pi * r1 * r1;
            double sa1 = s1 * s1;

            Console.WriteLine("Площадь круга с рандомной стороной {0} равна {1}", Math.Round(r1, 2), Math.Round(ca1, 2));
            Console.WriteLine("Площадь квадрата с рандомной стороной {0} равна {1}", Math.Round(s1, 2), Math.Round(sa1, 2));
            Console.ReadKey();
        }
    }
}
