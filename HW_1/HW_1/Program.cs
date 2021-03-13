using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            const double Pi = 3.14;
            double r;
            double s;

            int i = 0;
            while (i < 3)
            {
                Console.Write("Введите значение радиуса круга ->");
                string rstring = Console.ReadLine();

                Console.Write("Введите значение стороны квадрата ->");
                string sstring = Console.ReadLine();

                Double.TryParse(rstring, out r);
                if (r != 0)
                {
                    double ca = Pi * r * r;
                    Console.WriteLine("Площадь круга равна {0}", Math.Round(ca, 2));
                }
                else
                {
                    i++;
                }
                Double.TryParse(sstring, out s);
                if (s != 0)
                {
                    double sa = s * s;
                    Console.WriteLine("Площадь квадрата равна {0}", Math.Round(sa, 2));
                }
                else
                {
                    i++;
                }
                if (i >= 3)
                {
                    Random rnd = new Random();
                    double r1 = (rnd.NextDouble() * (5 - 0.5)) + 0.5;
                    double s1 = (rnd.NextDouble() * (5 - 0.5)) + 0.5;
                    double ca1 = Pi * r1 * r1;
                    double sa1 = s1 * s1;

                    Console.WriteLine("Площадь круга с рандомной стороной {0} равна {1}", Math.Round(r1, 2), Math.Round(ca1, 2));
                    Console.WriteLine("Площадь квадрата с рандомной стороной {0} равна {1}", Math.Round(s1, 2), Math.Round(sa1, 2));

                }
                Console.ReadKey();
            }
        }
    }
}
