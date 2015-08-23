using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the distance");
            double a = Convert.ToDouble(Console.ReadLine());
            double fare = 2.40 + a * 0.4;
            Console.WriteLine(fare);
        }
    }
}
