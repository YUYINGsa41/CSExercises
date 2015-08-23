using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("enter a number");
            double a = Convert.ToDouble(Console.ReadLine());
            double b;
            b = Math.Sqrt(a);
            Console.WriteLine("{0:0.000}",b);
        }
    }
}
