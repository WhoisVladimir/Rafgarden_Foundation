using System;

namespace Rafgarden_Foundation
{
    class KaratsubasMultiply
    {
        public static long KaratsubaMethod(int x, int y)
        {
            int xLength = x.ToString().Length;
            int yLength = y.ToString().Length;

            if (xLength == 1 || yLength == 1) return x * y;
            
            int nLength = Math.Max(xLength, yLength);
            int midLength = nLength / 2;

            int a = x / (int)Math.Pow(10, midLength);
            int b = x % (int)Math.Pow(10, midLength);
            int c = y / (int)Math.Pow(10, midLength);
            int d = y % (int)Math.Pow(10, midLength);

            int p = a + b;
            int q = c + d;
            long ac = KaratsubaMethod(a, c);
            long bd = KaratsubaMethod(b, d);
            long pq = KaratsubaMethod(p, q);

            long adbc = pq - ac - bd;

            long result = (long)(Math.Pow(10,midLength*2) * ac + Math.Pow(10, midLength) * adbc + bd);
            return result;
        }

        public static void Demo()
        {
            long firstExample = KaratsubaMethod(5678, 1234);
            Console.WriteLine($"5678 * 1234 = {firstExample}");

            long secondExample = KaratsubaMethod(10000, 123456789);
            Console.WriteLine($"10000 * 123456789 = {secondExample}");
        }
    }
}
