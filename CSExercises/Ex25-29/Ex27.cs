using System;
namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            int y = 0;
            Console.WriteLine("X\tY");
           for(int i=-5;i<6;i++)
           {
               y = 2 * i * i - 4 * i + 3;
               Console.WriteLine("{0:0.0}\t{1:0.0}",i,y);
           }
           Console.WriteLine("=====================");

           for (int j = -5; j < 6; j++)
           {
               y = 2 * j * j - 4 * j + 3;
               for (int k = 0; k <= y; k++)
               {
                   Console.Write("*");
               }
               Console.WriteLine();
               //highlight
           }
        }
    }
}
