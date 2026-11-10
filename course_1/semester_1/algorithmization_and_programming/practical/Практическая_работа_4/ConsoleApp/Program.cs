using System;
class Program
{
    static void Main(string[] args)
    {
        long maxn = Convert.ToInt64(Console.ReadLine());
        long cnt = 0;
        for (long n = 1; n <= maxn; ++n)
        {
            for (long k = n + 1; k <= n * 2; ++k)
            {
                long tmp_n = n;
                long z = 0;
                bool flag = true;
                while (tmp_n != 0)
                {
                    tmp_n *= 2;
                    tmp_n -= k;
                    if (tmp_n < 0)
                    {
                        flag = false;
                        break;
                    }

                    ++z;
                }

                if (flag)
                {
                    ++cnt;
                    Console.WriteLine($"{n} {k} {z}");
                }
            }
        }
        Console.WriteLine($"{cnt}");
    }
}
