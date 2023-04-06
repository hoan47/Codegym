using System;

namespace Test01
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = -1, n, m;
            while (choice != 0)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Draw the triangle");
                Console.WriteLine("2. Draw the square");
                Console.WriteLine("3. Draw the rectangle");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Draw the triangle\nSquared angle: ");
                        n = int.Parse(Console.ReadLine());
                        for(int i=0, j=1, k=2; i<n*(n+1)/2; i++)
                        {
                            if(i==j)
                            {
                                Console.WriteLine();
                                j = k * (k + 1) / 2; k++;
                            }
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.Write("Draw the square\nSquare edge: ");
                        n = int.Parse(Console.ReadLine());
                        for(int i=0; i<n*n; i++)
                        {
                            if (i % n == 0 && i != 0) 
                            {
                                Console.WriteLine();
                            }
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.Write("Draw the rectangle\nWidth: ");
                        n = int.Parse(Console.ReadLine());
                        Console.Write("Hight: ");
                        m = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n * m; i++)
                        {
                            if (i % m == 0)
                            {
                                Console.WriteLine();
                            }
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
            }
        }
    }
}