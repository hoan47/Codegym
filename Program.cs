using System;

namespace Test01
{
    class Program
    {
        static void Main(string[] args)
        {
            float weight, height;
            Console.WriteLine("Please enter a height");
            weight = float.Parse(Console.ReadLine());

            height = float.Parse(Console.ReadLine());

            float bmi;
            bmi = weight / height;
            bmi = (float)Math.Round(bmi, 1);
            Console.Write("BMI: " + bmi);
            if (bmi < 18.5)
                Console.WriteLine(" Underweight");
            else if (18.5 <= bmi && bmi < 25)
                Console.WriteLine(" Normal");
            else if (25 <= bmi && bmi < 30)
                Console.WriteLine(" Overweight");
            else
                Console.WriteLine(" Obese");
        }
    }
}