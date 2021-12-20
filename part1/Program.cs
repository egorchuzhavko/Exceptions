using System;
using System.ComponentModel;

namespace part1
{
    class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            double? a, b, c, p = null;
            try
            {
                Console.Write("Vvedite a: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Vvedite b: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Vvedite c: ");
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
            
            //задание 2
            int? n = null;
            try
            {
                Console.Write("Vvedite razmernost' massiva: ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n <= 0)
                    throw new Exception("n <= 0"); 
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Neverniy format dannih");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            int[,] mas = new int[Convert.ToInt32(n), Convert.ToInt32(n)];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mas[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            bool flag = true;
            for (int i = 0; i < n & flag; i++)
            {
                for (int j = 0; j < n & flag; j++)
                {
                    if (mas[i, j] != mas[j, i])
                        flag = false;
                }
            }

            Console.WriteLine(flag ? "Матрица симметрична" : "Матрица не симметрична");
        }
    }
}