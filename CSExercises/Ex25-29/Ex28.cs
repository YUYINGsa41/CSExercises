using System;
namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter an integer:");
            int a=Convert.ToInt32(Console.ReadLine());
            int i;
            int j=0;
            for (i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    j++;
                }
            }
                if (j != 0)
                    Console.WriteLine("Not Prime");
                else
                    Console.WriteLine("Prime");
           }



        }
    }

