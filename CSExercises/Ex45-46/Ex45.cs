
using System;
namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Plesae enter an amount(0.05-3.50,)");
          int a=Convert.ToInt32(100 *Convert.ToDouble( Console.ReadLine()));
           do
           {
               if (a >= 100)
               {
                   Console.WriteLine("100c");
                   a = a - 100;
               }
               if (a >= 50 && a < 100)
               {
                   a = a - 50;
                   Console.WriteLine("50c");
               }
               if (a >= 20 && a < 50)
               {
                   a = a - 20;
                   Console.WriteLine("20c");
               }
               if (a >= 5 && a < 20)
               {
                   a = a - 5;
                   Console.WriteLine("5c");
               }

           }while(a!=0);
            
                        

        }
    }
}
