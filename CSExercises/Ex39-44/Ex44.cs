
using System;
namespace CSExercises
{
    public class Ex44
    {
        public static string Substitute(string s, char c1, char c2)
        {
             char[] A = new char[s.Length];
                     string B=""; 
             for (int i = 0; i < s.Length; i++) 
             {    
                
                A[i]= Convert.ToChar (s.Substring(i,1)) ; 
                if(A[i]==c1) 
                { 
                     A[i]=c2; 
                } 

 
                B= B+A[i]; 
                     
            } 

 
                return B; 

        }
    }
}
