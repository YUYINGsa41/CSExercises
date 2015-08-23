using System;
namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter a three-digit number");
           int  a =Convert.ToInt32( Console.ReadLine());
            int b=a/100;
            int c=(a-100*(a/100))/10;
            int d=(a-100*b-10*c)/1;
            if (b * b * b + c * c * c + d * d * d == a)
            {
                Console.WriteLine("Armstrong number");
                   
            }
              
            
         
        }
    }
}