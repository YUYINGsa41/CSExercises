using System;
namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
// Console.WriteLine("enter an integer:");
            int k;
            for (k = 1; k <= 1000;k++ )
            {
                //int a = Convert.ToInt32(Console.ReadLine());
                int i;
                int j = 0;
                for (i = 2; i < k; i++)
                {
                    if (k % i == 0)
                    {
                        j++;
                    }
                }
                if (j == 0)

                //    Console.WriteLine("Not Prime");
                    Console.WriteLine("Prime:{0}",k);
            }
        }
    }
}
