using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            Console.WriteLine ("enter a number");
            double a=Convert.ToDouble(Console.ReadLine());
            double y = 0;
            y = 2 * a * a - 4 * a + 3;
            Console.WriteLine(y);

        }
    }
}
