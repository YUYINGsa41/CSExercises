using System;
namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter a string:");
         string a=Console.ReadLine();
            string [] A=new string [a.Length];
         int i;
            for(i=0;i<a.Length;i++)
            {
                A[i] = a.Substring(i,1);
            }
            Console.WriteLine(A);
            int j;
           string t;
            string[] B = new string[a.Length];
            B = A;
            for (j = 0; j <= a.Length / 2 - 1; j++)
            {
                t = B[a.Length - j - 1];
                B[a.Length - j - 1] = B[j];
                B[j] = t;
            }

            if (A == B)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palindrome");



        }
    }
}
