using System;
namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine("enter an integer:");
            // int a = Convert.ToInt32(Console.ReadLine());
            int j;
            int i;
            int sum;
            //can not put"int sum=0;"there
            for (j = 1; j <= 1000; j++)
            {
                sum = 0;
                //###assign in inner loop###//
                for (i = 1; i < j; i++)
                {
                    if (j % i == 0)
                    {
                        sum = sum + i;
                    }
                }
                if (sum == j)
                    Console.WriteLine("Perfect Number:{0}", j);
            }
            // else
            //     Console.WriteLine("NOT Perfect Number");

        }
    }
}
