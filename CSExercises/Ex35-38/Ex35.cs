using System;
namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter a phrase:");
            string phrase = Console.ReadLine();
            int n;
            n=phrase.Length;
            string [] A=new string[n];
            int i;
            int a=0;
            int e=0;
            int y=0;
            int o=0;
            int u=0;
              //int d=0; 
            for(i=0;i<n;i++)
           {
                A[i] = phrase.Substring(i,1);
                //if(A[i]=="a"||(A[i] == "e"||A[i] == "i"||A[i] == "o"||A[i] == "u")
                //d++;
                if (A[i] == "a")
                    a++;
                else if (A[i] == "e")
                    e++;
                else if (A[i] == "i")
                    y++;
                else if (A[i] == "o")
                    o++;
                else if (A[i] == "u")
                    u++;
            }
            Console.WriteLine("Number of a: {0}\nNumber of e: {1}\nNumber of i:{2}\nNumber of o: {3}\nNumber of u:{4}",a,e,y,o,u);


        }
    }
}
