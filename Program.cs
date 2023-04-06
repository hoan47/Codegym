using System;

namespace Test01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            for(int i=2; i<=Math.Sqrt(n); i++)
            {
                if(n%i==0)
                {
                    Console.WriteLine($"{n} is not a prime");
                    return;
                }
            }
            Console.WriteLine($"{n} is a prime");
        }
    }
}