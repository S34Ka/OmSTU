using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a = Convert.ToByte(Console.ReadLine());
            byte b = Convert.ToByte(Console.ReadLine());
            byte c = Convert.ToByte(Console.ReadLine());
            byte sx = Convert.ToByte(Console.ReadLine());
            byte sy = Convert.ToByte(Console.ReadLine());
            byte sz = Convert.ToByte(Console.ReadLine());
            byte fx = Convert.ToByte(Console.ReadLine());
            byte fy = Convert.ToByte(Console.ReadLine());
            byte fz = Convert.ToByte(Console.ReadLine());

            double s = 0;
            byte test = 0;

            if (((sx == 0 && fx == 0) || (sy == 0 && fy == 0) || (sz == 0 && fz == 0)) || ((sx == a && fx == a) || (sy == b && fy == b) || (sz == c && fz == c)))
            {
                s = Math.Sqrt((fx - sx) * (fx - sx) + (fy - sy) * (fy - sy) + (fz - sz) * (fz - sz));
                Console.WriteLine($"{s:F3}");
                test = 1;
            }
            if (((((sx == 0 || sx == a) || (fx == 0 || fx == a)) && (sx != fx)) || (((sy == 0 || sy == b) || (fy == 0 || fy == b)) && (sy != fy)) || (((sz == 0 || sz == c) || (fz == 0 || fz == c)) && (sz != fz))) && (test == 0))
            {
                s = fx - sx + fy - sy + fz - sz;
                Console.WriteLine($"{s:F3}");

            }
            if (((sx == 0 && fx == a) || (sx == a && fx == 0)) || ((sy == 0 && fy == b) || (sy == b && fy == 0)) || ((sz == 0 && fz == c) || (sz == c && fz == 0)))
            {
                s = Math.Sqrt((fx - sx) * (fx - sx) + (fy - sy) * (fy - sy) + (fz - sz) * (fz - sz));
                Console.WriteLine($"{s:F3}");
            }
        }
    }
}
