using System;
namespace CSExercises
{
    public class Ex41
    {
        public static bool InString(string s1, string s2)
        {   bool a=false;
            if (s2.Length > s1.Length)
            return a;
            else if (s2.Length <= s1.Length)
            {
                for (int i = 0; i <= s1.Length - s2.Length; i++)
                {
                    if (s1.Substring(i, s2.Length) == s2)
                        a = !a;

                }
            }
            return a;

        }
    }
}
