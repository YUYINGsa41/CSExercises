using System;

namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            Random r = new Random();
            int SecrectNumber = r.Next(0, 10);
            int guess;
            int i=0;
            do
            {
                Console.WriteLine("Please guess an integer(0-9)");
                guess=Convert.ToInt32(Console.ReadLine());
                i++;
                if (guess == SecrectNumber)
                {
                    Console.WriteLine("Congratulation!" + i);
                   
                }
                else
                    Console.WriteLine("Try again");
                }while(guess!=SecrectNumber);
            if (i <= 2)
                Console.WriteLine("You are a Wizard!");
            if(i>2 && i<=5)
                Console.WriteLine("You are a good guess");
            else
                Console.WriteLine("You are lousy!");

            }

        
    
    }
}

