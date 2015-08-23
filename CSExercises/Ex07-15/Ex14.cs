using System;
namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter a length");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter another length");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the last length");
            double c = Convert.ToDouble(Console.ReadLine());
            if (a + b <= c || a + c <= b || b + c <= a)
                Console.WriteLine("not a triangle,please enter the length rightly");
            else
            {
                double s = (a + b + c) / 2;
                double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                Console.WriteLine(area);
            }


        }
    }
}