using System;
namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int[] A = new int[] { 86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79 };
            int i, j, t;
            for (i = 0; i < A.Length - 1; i++)
            {
                for (j = i+1; j < A.Length; j++)
                    //j=i+i;$$$not j=1;
                {
                    if (A[j] > A[i])
                    {
                        t = A[j];
                        A[j] = A[i];
                        A[i] = t;
                    }


                }
                // for (k = 0; k < A.Length; k++)
                //  {
                //      Console.Write("{0}\t", A[k]);
                //  }
                // }
              //  for (k = 0; k < A.Length; k++)
              //  {
              //      Console.Write("{0}\t", A[k]);
              //  }
            //    Console.WriteLine();
                for (int k = 0; k < A.Length; k++)
                {
                    Console.Write("{0} ", A[k]);
                }
                Console.WriteLine();//write to have a space line
                
            }
           

           // for (int k = 0; k < A.Length; k++)
          //  {
          //      Console.Write("{0}", A[k]);
          //  }
          //  Console.WriteLine();
        }

    }
}