
using System;
namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            Console.Write("enter an integer:");
           int A=Convert.ToInt32( Console.ReadLine());
            Console.Write("enter another integer:");
           int B=Convert.ToInt32( Console.ReadLine());
            int a=A;
            int b=B;
           while (a != b) 
            {   
                if(a<b)
                    b=a;
                else
                    a=b;
             }
           int HCF = a;
           Double LCM = (A * B) / HCF;
           Console.WriteLine("HCF:{0}\nLCM:{1}",HCF,LCM);
        }
    }
}
