using System;

namespace part1
{
    class Program
    {
        static void Main(string[] args)
        {
            double? a, b, c, p = null;
            try
            {
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
                c = Convert.ToDouble(Console.ReadLine());
                if (a == 0 | b == 0 | c == 0)
                    throw new Exception("Одна или несколько сторон равны нулю");
                if (a < 0 | b < 0 | c < 0)
                    throw new Exception("Одна или несколько сторон имеют отрицательное значение");
                p = (a + b + c) / 2;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Неверный тип данных");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\n" + p);
        }
    }
}