using System;
namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            Console.WriteLine  ("Please enter your name ");
            string name=Console.ReadLine();
                Console.WriteLine  ("Please enter your gender(M or F assume capital letter) ");
                string gender = Console.ReadLine();
                Console.WriteLine("Please enter your age ");
                int age = Convert.ToInt32(Console.ReadLine());
                if (gender == "F" )
                {if (age >= 40 )
                    Console.WriteLine("Good mornig Aunty " + name);
                else
                    Console.WriteLine("Good morning Ms "+name);
                }
                else if (gender == "M")
                {
                    if (age >= 40)
                        Console.WriteLine("Good mornig Uncle " + name);
                    else

                        Console.WriteLine("Good mornig Mr " + name);
                }
        }
    }
}