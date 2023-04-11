using System;

namespace Test01
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, S = 0;
            m = int.Parse(Console.ReadLine());
            int[,] a = new int[m, m];
            for(int i=0; i<m; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for(int j=0; j<m; j++)
                {
                    a[i, j] = int.Parse(s[j]);
                }
            }
            for (int i = 0, j = 0; i < m; i++, j++)
                S += a[i, j];
            Console.WriteLine(S);
        }
    }
}