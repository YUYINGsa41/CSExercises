using System;
namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            int[] sales = new int[12];
            int i;
            
            int sum = 0;
            int a = 0;
            int b = 0;

            for ( i = 0; i < sales.Length; i++)
            {
                Console.WriteLine("enter sales for month {0}", i);
                sales[i] = Convert.ToInt32(Console.ReadLine());
            
            }
            int min = sales[0];
            int max = sales[0];
            int j;
            for ( j = 0; j < sales.Length; j++)
              
            {
                if (sales[j] < min) 
                    //highlight
                {
                   min = sales[j];
                   a = j; 
                 }
                else  if (sales[j] >= max)
                {
                    max = sales[j];

                    b = j;
                }

                sum = sum + sales[j];
                }
                Console.WriteLine("Maximum Sales:{0}", b);
                Console.WriteLine("Minimum Sales:{0}", a);
                Console.WriteLine("Average Sales:{0}", sum / sales.Length);
            }
        }
    }

