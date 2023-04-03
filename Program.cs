using System;

namespace Test01
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Linear Equation Resolver");
            Console.WriteLine("Given a equation as 'a * x + b = 0', please enter constants:");
            double a, b;
            Console.Write("a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            b = Convert.ToDouble(Console.ReadLine());
            if(a==0)
                if(b==0)
                {
                    Console.Write("The solution is all x!");
                }
                else
                {
                    Console.Write("Nod solution!");
                }
            else
            {
                Console.Write("The solution is: {0}!", -b/a);
            }
        }
    }
}