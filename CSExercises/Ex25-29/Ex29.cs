using System;
namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter an integer:");
            int a = Convert.ToInt32(Console.ReadLine());
            int i;
            int sum=0;
            for (i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    sum = sum + i;
                }



            }
            if (sum == a)
                Console.WriteLine("Perfect Number");
            else
                Console.WriteLine("NOT Perfect Number");


        }
    }
}
