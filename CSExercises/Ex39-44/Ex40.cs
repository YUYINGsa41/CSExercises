using System.Data.SqlClient;
using System;
namespace CSExercises
{
    public class Ex40
    {
       public static void Main(string[] args)
        {
            int i;
            double a = 0;
            for (i = 1; i < 26; i++)
            {
                a = SQT(i);
                Console.WriteLine(" {0:0.0000}",a);

            }
        }

        public static double SQT(int y)
        {

            return Math.Sqrt(y);
            
              
        }
    }
}
