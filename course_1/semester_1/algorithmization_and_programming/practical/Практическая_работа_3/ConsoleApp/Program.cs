using System;
class Program
{
    static void Main(string[] args)
    {
        ulong n = Convert.ToUInt64(Console.ReadLine());
        if (n > 0 && n <= 10_000_000)
        {
            ulong res = _(n);
            Console.WriteLine($"{res}");
        }
    }

    private static ulong _(ulong n)
    {
        if (n < 3) return 0;

        ulong[] arr = new ulong[n + 1];

        arr[0] = 0;
        arr[1] = 0;
        arr[2] = 0;
        arr[3] = 1;

        for (ulong i = 4; i <= n; ++i)
        {
            ulong half_1 = i / 2;
            ulong half_2 = i - half_1;
            arr[i] = arr[half_1] + arr[half_2];
        }

        return arr[n];
    }
}
