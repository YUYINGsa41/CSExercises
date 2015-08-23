using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter a temperature in Centigrade scale");
            double F = 1.8 * Convert.ToDouble(Console.ReadLine())+32;
            Console.WriteLine("{0}",F);
                
        }
    }
}
