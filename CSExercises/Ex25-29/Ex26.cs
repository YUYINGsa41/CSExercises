using System;
namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
           
            int i;
            double inverse;
            double SquareRoot;
            double square;

            for (i = 1; i < 11; i++)
            { 
                inverse = 1 / Convert.ToDouble(i);
                SquareRoot = Math.Sqrt(Convert.ToDouble(i));
                square = Convert.ToDouble(i) * Convert.ToDouble(i);
                Console.WriteLine("number:{0},inverse:{1:0.0##},square root:{2:0.0##},square:{3:0.0}", i, inverse, SquareRoot, square);

            }
           
        }
    }
}
