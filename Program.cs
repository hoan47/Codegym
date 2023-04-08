using System;

namespace Test01
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int[] a = new int[m];
            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < m; i++)
            {
                a[i] = int.Parse(s[i]);
            }
            int X = int.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            if(index<=1 || a.Length-1<=index)
            {
                Console.WriteLine("Khong chen duoc");
                return;
            }    
            Array.Resize(ref a, a.Length + 1);
            Array.Copy(a, index, a, index + 1, a.Length - 1 - index);
            a[index] = X;
            for (int i = 0; i < a.Length; i++) 
            {
                Console.Write($"{a[i]} ");
            }   
        }
    }
}