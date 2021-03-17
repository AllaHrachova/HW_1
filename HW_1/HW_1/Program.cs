using System;

namespace ConsoleApp5
{

    class Program
    {
        static void Main(string[] args)
        {

            const double Pi = 3.14;
            int i = 0;
            string Result1;
            string Result2;

            Circle circle1 = new Circle();
            Square square1 = new Square();

            while (i < 3)
            {
                Console.Write("Введите значение радиуса круга ->");
                string rstring = Console.ReadLine();

                Console.Write("Введите значение стороны квадрата ->");
                string sstring = Console.ReadLine();

                Double.TryParse(rstring, out circle1.r);
                if (circle1.r != 0)
                {
                    circle1.ca = Pi * circle1.r * circle1.r;
                    Console.WriteLine("Площадь круга равна {0}", Math.Round(circle1.ca, 2));
                }
                else
                {
                    i++;
                }

                Double.TryParse(sstring, out square1.s);
                if (square1.s != 0)
                {
                    square1.sa = square1.s * square1.s;
                    Console.WriteLine("Площадь квадрата равна {0}", Math.Round(square1.sa, 2));
                }
                else
                {
                    i++;
                }

                if (i >= 3)
                {
                    Random rnd = new Random();
                    circle1.r = (rnd.NextDouble() * (5 - 0.5)) + 0.5;
                    square1.s = (rnd.NextDouble() * (5 - 0.5)) + 0.5;
                    circle1.ca = Pi * circle1.r * circle1.r;
                    square1.sa = square1.s * square1.s;

                    Console.WriteLine("Площадь круга с рандомной стороной {0} равна {1}", Math.Round(circle1.r, 2), Math.Round(circle1.ca, 2));
                    Console.WriteLine("Площадь квадрата с рандомной стороной {0} равна {1}", Math.Round(square1.s, 2), Math.Round(square1.sa, 2));
                }

                if (2 * (circle1.r) > square1.s)

                {
                    Result1 = "НЕТ";
                }
                else if (2 * (circle1.r) <= square1.s)
                {
                    Result1 = "ДА";
                }
                else Result1 = "Некорректные данные";

                if (2 * (circle1.r) < square1.s * Math.Sqrt(2))

                {
                    Result2 = "НЕТ";
                }
                else if (2 * (circle1.r) >= square1.s * Math.Sqrt(2))
                {
                    Result2 = "ДА";
                }
                else Result2 = "Некорректные данные";

                Console.WriteLine("Круг умещается в квадрат - {0}", Result1);
                Console.WriteLine("Квадрат умещается в круг - {0}", Result2);
                Console.ReadKey();
            }
        }
    }
}