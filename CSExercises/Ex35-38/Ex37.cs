using System;
namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter a sentence");
            string sentence=Console.ReadLine();
            string[] A = sentence.Split(' ');
            string[] B = new string[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                B[i] = (A[i].Substring(0, 1)).ToUpper() + A[i].Substring(1, A[i].Length-1);
                 Console.Write("{0} ",B[i]);
  
            }
            
               
  

        }
    }
}
