using System;
namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter quantity for TV:");
            int QuantityOfTV = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter quantity for DVD:");
            int QuantityOfDVD = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter quantity for MP3:");
            int QuantityOfMP3 = Convert.ToInt32(Console.ReadLine());
            double priceTV=QuantityOfTV*900;
                double priceDVD=QuantityOfDVD*500;
            double priceMP3=QuantityOfMP3*700;

            if (priceTV + priceDVD >= 0 && priceTV + priceDVD <= 5000)
            {
                Console.WriteLine("The Total Price is ${0:0000}", (priceTV + priceDVD + priceMP3));

            }
            else if (priceTV + priceDVD > 5000 && priceTV + priceDVD <= 10000)
            {
                Console.WriteLine("The Total Price is ${0:0000}", ((1-0.1)*(priceTV + priceDVD )+ priceMP3));
            }
            else if (priceTV + priceDVD > 10000)
            {
                Console.WriteLine("The Total Price is ${0:0000}", ((1 - 0.15) * (priceTV + priceDVD) + priceMP3));
            }



        }
    }
}