using System;

namespace Test01
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, max;
            max = int.MinValue;
            m = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            int[,] a = new int[m, n];
            for(int i=0; i<m; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for(int j=0; j<n; j++)
                {
                    a[i, j] = int.Parse(s[j]);
                    if (a[i, j] > max)
                        max = a[i, j];
                }
            }
            Console.WriteLine(max);
        }
    }
}