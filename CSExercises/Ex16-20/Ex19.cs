using System;
namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the distance(/km)");
            double distance = Convert.ToDouble(Console.ReadLine());
            if (distance * 1000>=0 && distance * 1000 <= 500)
                Console.WriteLine("The Cost is:$2.40");
            else if (distance * 1000 > 500 && distance * 1000 <= 9000)
                Console.WriteLine("The Cost is:${0:0.00}", (2.40 + 0.04 * (distance * 10 - 5)));
            else if (distance * 1000 > 9000)
                Console.WriteLine("The Cost is:${0:0.00}", (2.40 + 0.04 * 85 + 0.05 * (distance * 10 - 90)));
            else
                Console.WriteLine("There is an Error");
        }
    }
}