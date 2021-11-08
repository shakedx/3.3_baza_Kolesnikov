using System;

namespace Kolesnikov_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите n:");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите x:");
                double x = double.Parse(Console.ReadLine());
                double S = 0;
                for (int i = 1, h = 1; i < n; i++, h += 2)
                {
                    long F = 1;
                    for (int j = 1; j <= h; j++) F *= j;
                    S += 1 - 3 * (x * x) + 5 * (x * x * x * x) - 10 * (x * x * x * x * x * x) / F;


                }
                Console.WriteLine("S={0:F2}", S);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
