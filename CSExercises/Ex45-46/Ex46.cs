using System;
namespace CSExercises
{
    public class Ex46
    {
        public static void Main(string[] args)
        {
            int[] A = new int[] {0,0,0,0,0,0,0,0,0,0};
            int[] B = new int[50];
            int j;
            Random r=new Random();
            for(int i=0;i<50;i++)
            {
                B[i] = r.Next(0,10);
                for ( j=0; j < 10; j++)
                {
                    if (B[i] == j)
                        A[j] = A[j] + 1;
              
                }

            }
            Console.WriteLine("Number\tCount\n");
            for (int k = 0; k < 10; k++)
            {
                
                Console.WriteLine("{0}\t{1}",k,A[k]);
            }
                

        }
    }
}
