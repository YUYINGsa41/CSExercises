
using System;
namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int i;
                      for (i = 1; i < n+1; i++)
            {
                if (n % i == 0)
                 Console.WriteLine(i);   
            }
 Console.WriteLine("===================");
            int J;
            for (J = n; J > 0; J--)
            {
                if (n % J == 0)
                    Console.WriteLine(J);
            }
               
        }
    }
}
