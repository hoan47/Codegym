using System;

namespace Test01
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            s = Console.ReadLine();
            if (s.Length == 1)
            {
                One(s);
            }
            else if(s.Length == 2)
            {
                Two(s);
            }
            else
            {
                Three(s);
            }
        }
        static void One(string s)
        {
            Console.WriteLine(Read(char.Parse(s)));
        }
        static void Two(string s)
        {
            if(int.Parse(s)<20)
            {
                Console.Write($"{Read(s[1])}teen");
            }
            else
            {
                Console.Write($"{Read(s[0])}ty {Read(s[1])}");
            }
        }
        static void Three(string s)
        {
            Console.Write($"{Read(s[0])} hundred and ");
            Two(s.Substring(1, 2));
        }
        static string Read(char s)
        {
            switch (s)
            {
                case '0':
                    return "zero";
                    break;
                case '1':
                    return "one";
                    break;
                case '2':
                    return "two";
                    break;
                case '3':
                    return "three";
                    break;
                case '4':
                    return "four";
                    break;
                case '5':
                    return "five";
                    break;
                case '6':
                    return "six";
                    break;
                case '7':
                    return "seven";
                    break;
                case '8':
                    return "eight";
                    break;
                case '9':
                    return "nine";
                    break;
            }
            return "0";
        }
    }
}
