using System;
namespace CSExercises
{
    public class Ex39
    {
        public static long Factorial(long n)
        {
            long x=1;
            long i;
            for (i = n; i >= 1; i--)
            {
                x = x * i;
            }


                return x;
        }
    }
}
