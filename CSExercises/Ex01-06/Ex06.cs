using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
           int a = Convert.ToInt32(Console.ReadLine());
            double b;
            b = Math.Sqrt(Convert.ToDouble(a));
            Console.WriteLine(b);
        }
    }
}
