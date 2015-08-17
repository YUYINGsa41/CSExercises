namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter your name :");
            string name = System.Console.ReadLine();
            System.Console.WriteLine("Please enter your capital letter of genter (M or F assume capital letter):");
            string CapitalLetterOfGender = System.Console.ReadLine();
            if (CapitalLetterOfGender == "F")
                System.Console.WriteLine("Good Morning Ms." + name);
            else if (CapitalLetterOfGender == "M")
                System.Console.WriteLine("Good Morning Mr." + name); 
        }
    }
}