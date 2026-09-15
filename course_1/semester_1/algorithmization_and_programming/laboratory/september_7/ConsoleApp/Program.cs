using System;
//using System.Security.Cryptography;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void _1(int k)
        {
            int h = k / 3600;
            int m = k % 3600 / 60;
            int s = k % 60;
            Console.WriteLine($"{h} час\t{m} минута\t{s} секунда");
        }
        
        static void _2(int a, int b, int h)
        {
            double s = 0.5 * (a + b) * h;
            double v = h * (a + b + Math.Sqrt(a * b)) / 3.0;
            Console.WriteLine($"{s} площадь\t{v} объём");
        }

        static void _3(int r)
        {
            double v = 4.0 / 3.0 * Math.PI * Math.Pow(r, 3);
            double s = Math.PI * r * r;
            double ratio = v / s;
            Console.WriteLine($"{v} объём\t{s} площадь\t{ratio} соотношение");
        }

        static void _4(int a, int b, int c)
        {
            double ma = 0.5 * Math.Sqrt(2 * (b * b + c * c) - a * a);
            double mb = 0.5 * Math.Sqrt(2 * (a * a + c * c) - b * b);
            double mc = 0.5 * Math.Sqrt(2 * (a * a + b * b) - c * c);
            Console.WriteLine($"{ma} медиана к стороне a\t{mb} медиана к стороне b\t{mc} медиана к стороне c");
        }

        static void _5(int r, int h)
        {
            double l = Math.Sqrt(r * r + h * h);
            double s = Math.PI * r * (r + l);
            double v = Math.PI * r * r * h / 3.0;
            Console.WriteLine($"{s} площадь\t{v} объём");
        }

        static void _6(int r)
        {
            double v = 4.0 / 3.0 * Math.PI * Math.Pow(r, 3);
            double s = 4.0 * Math.PI * r * r;
            Console.WriteLine($"{s:n3} площадь\t{v:n3} объём");
        }

        static void _7(int[] a, int[] b)
        {
            double ro = Math.Sqrt((b[0] - a[0]) * (b[0] - a[0]) + (b[1] - a[1]) * (b[1] - a[1]));
            Console.WriteLine($"{ro} расстояние");
        }

        static void _8(int a, int b)
        {
            double maximum = (a + b + Math.Abs(a - b)) * 0.5;
            Console.WriteLine($"{maximum} максимум");
        }

        static void _9(int a, int b)
        {
            int c = a + b;
            a = c - a;
            b = c - b;
            Console.WriteLine($"{a}\t{b} поменялись местами");
        }

        static void _10(int a, int b, int c)
        {
            double mean = (a + b + c) / 3.0;
            Console.WriteLine($"{mean} среднее арифметическое");
        }

        static void _11(int a, int b, int c)
        {
            double discount = 0.87;
            double discounted_price = (a + b + c) * discount;
            Console.WriteLine($"{discounted_price:n1} цена со скидкой");
        }

        static void _12(int a)
        {
            int sum_numbers = a / 100 + a / 10 % 10 + a % 10;
            Console.WriteLine($"{sum_numbers} сумма цифр");
        }

        static void _13(int a, int b)
        {
            double hypot = Math.Sqrt(a * a + b * b);
            Console.WriteLine($"{hypot:n5} гипотенуза");
        }

        static void Main()
        {
            _1(9876);
            _2(9, 8, 7);
            _3(9);
            _4(5, 4, 3);
            _5(9, 8);
            _6(9);
            _7(new int[] {1, 1}, new int[] {0, 0});
            _8(9, 1);
            _9(9, 1);
            _10(9, 8, 6);
            _11(9, 8, 7);
            _12(987);
            _13(4, 3);
        }
    }
}
