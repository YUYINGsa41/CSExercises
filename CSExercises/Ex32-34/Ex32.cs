using System;
namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            int[] sales = new int[5];
            int i;
            int min = sales[0];
            int max = sales[0];
            int sum = 0;

            for (i = 0; i < sales.Length; i++)
            {
                Console.WriteLine("enter sales for month {0}", i);
                sales[i] = Convert.ToInt32(Console.ReadLine());
            
                //take in sales
               // max=min = sales[0];
                
                    if (sales[i] <= min)
                {
                    min = sales[i];
                  //A=I;
                 // Console.WriteLine("Minimum Sales:{0}", i);  
                }
                  

               // if (i == sales.Length - 1)
            

                       // Console.WriteLine("Minimum Sales:{0}", min);
               // }
           // }
               // max = sales[0];
                if ( sales[i] >= max)
                {
                    max = sales[i];
                  //  Console.WriteLine("Maximum Sales:{0}",i);
                }

                   // if (i == sales.Length - 1)
                   // {
                   //     Console.WriteLine("Maximum Sales:{0}", );
                   //       Console.WriteLine("Minimum Sales:{0}", min);  
                   // }
                //}
               // sum = 0;
                sum = sum + sales[i];
                if (i == sales.Length - 1)
                {
                    Console.WriteLine("Average Sales:{0}", sum / sales.Length);
                }
            }
                 
            
        }
    }
}
