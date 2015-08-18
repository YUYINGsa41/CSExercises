
using System;
namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            double N = Convert.ToDouble(Console.ReadLine());
            Random r = new Random();
            double G = r.Next(1, Convert.ToInt32(N)+1);
            double g = G;

            while (N != Math.Round(g * g,5))
            {
                 g = (g + N / g) / 2;
            }
            Console.WriteLine("The square root is:{0:0.#####}",g);

        }
    }
}
