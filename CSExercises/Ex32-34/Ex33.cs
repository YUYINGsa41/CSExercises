using System;
namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int[] A = new int[] {86,35,41,49,89,51,11,71,50,75,25,58,40,14,44,3,63,81,93,79 };
            int i;
            int j;
            int t;

            for(i=0 ; i < A.Length-1;i++)
            {
                for(j=i+1;j<A.Length;j++)
                {
                    if (A[j] > A[i])
                    {
                        t = A[j];
                        A[j] = A[i];
                        A[i] = t;
                        Console.WriteLine(A);
                    }
                }
            }
        }
    }
}
