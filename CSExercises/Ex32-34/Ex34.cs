using System;
namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            int [,] A = new int[,]{{56,84,68,29},{94,73,31,89},{41,63,36,90},{99,9,18,17},{62,3,65,75},{40,96,53,23},{81,15,27,30},{21,70,100,22},{88,50,13,12},{48,54,52,78},{64,71,67,25},{16,93,46,72}};
         
            int i;
            int j;
            int sum=0;
            for(i=0;i<A.GetLength(0);i++)
            {
                for(j=0;j<A.GetLength(1);j++)
                {
                    sum = sum + A[i,j];
                }
                Console.WriteLine("the total marks of student{0}:{1}",i,sum);
             }
            //Console.WriteLine("the overall average of marks:{0}", sum / (A.GetLength(0)*A.GetLength(1)));
           // int sum1 = 0;
           // int k;
           // int h;
           // for (h = 0; h < A.GetLength(1); h++)
           // {
              //  for (k = 0; k < A.GetLength(0); k++)
              //  {
               //     sum1 = sum1 + A[k, h];
              //  }
             //   Console.WriteLine("the average of subject{0}:{1}", h, sum1 / A.GetLength(0));
           // }
        }


    }
}
