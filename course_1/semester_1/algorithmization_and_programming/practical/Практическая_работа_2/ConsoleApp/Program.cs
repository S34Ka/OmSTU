using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void _(ulong n)
        {
            double[] all_prices = new double[n];

            for (ulong i = 0; i < n; ++i)
            {
                ulong xi1 = Convert.ToUInt64(Console.ReadLine());
                ulong yi1 = Convert.ToUInt64(Console.ReadLine());
                ulong zi1 = Convert.ToUInt64(Console.ReadLine());

                ulong xi2 = Convert.ToUInt64(Console.ReadLine());
                ulong yi2 = Convert.ToUInt64(Console.ReadLine());
                ulong zi2 = Convert.ToUInt64(Console.ReadLine());

                double ci1 = Convert.ToDouble(Console.ReadLine());
                double ci2 = Convert.ToDouble(Console.ReadLine());


                ulong full_s1 = (xi1 * yi1 + xi1 * zi1 + yi1 * zi1) * 2;
                ulong v1 = xi1 * yi1 * zi1;

                ulong full_s2 = (xi2 * yi2 + xi2 * zi2 + yi2 * zi2) * 2;
                ulong v2 = xi2 * yi2 * zi2;

                double m = ((full_s1 * ci2) - (full_s2 * ci1)) / ((full_s1 * v2) - (full_s2 * v1));

                all_prices[i] = m;
            }

            double minimal_price = double.MaxValue;
            ulong number_company = ulong.MaxValue;
            ulong cnt = 0;

            foreach (double price in all_prices)
            {
                ++cnt;

                if (price < minimal_price)
                {
                    minimal_price = price;
                    number_company = cnt;
                }

            }

            minimal_price *= 1000;

            Console.WriteLine($"{number_company} {minimal_price:F2}");
            


        }
        static void Main(string[] args)
        {
            ulong n = Convert.ToUInt64(Console.ReadLine());
            _(n);
        }
    }
}
