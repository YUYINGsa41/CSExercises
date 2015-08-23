using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter x1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter y1");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter x2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter y2");
            double y2 = Convert.ToDouble(Console.ReadLine());
            double Distance = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
            Console.WriteLine(Distance);
        }
    }
}
