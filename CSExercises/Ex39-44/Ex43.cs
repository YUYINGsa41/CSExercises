using System;
namespace CSExercises
{
    public class Ex43
    {
        public static string Hex(int i)
        {
             char[] A = new char[] {'0','1','2','3','4','5','6','7','8','9','A','B','C','D','E','F'};
            int B;
            B = i / 16;
           string  C  = "";
            C="B"+ A [ i%16 ];
            return C;
        }
    }
}
