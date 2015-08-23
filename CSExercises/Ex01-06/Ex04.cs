using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex04
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            double a = Convert.ToDouble(Console.ReadLine());
            double b;
            b = Math.Sqrt(a);
            Console.WriteLine(b);
        }
    }
}
