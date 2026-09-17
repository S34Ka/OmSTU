using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void _(Int64 n, Int16 l, Int16 w, Int16 k)
        {
            //Int64 ro_kolodets = 2 * k * n;
            //Int64 ro_l = 2 * l * n;
            //double ro_w = 2 * (w + w * n) * 0.5 * n;
            //double output = ro_kolodets + ro_l + ro_w;

            Int64 output = n * (2 * (k + l) + w * (n + 1));
            Console.WriteLine(output);
        }

        static void Main(string[] args)
        {
            _(1_000, 80, 87, 50);
            _(1_000_000, 72, 43, 51);
            _(100000_000, 100, 100, 100);
        }
    }
}
