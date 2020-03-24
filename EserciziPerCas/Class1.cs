using System;

namespace EserciziPerCas
{
    public class Class1
    {
        public static bool AreEquals(string s1,string s2)
        {
            bool n;
            if (s1 == s2)
            {
                n = true;
            }
            else
            {
                int c=0;
                n = false;
                for(int i=0;i<s1.Length;i++)
                {
                    if(s1[i]==s2[i])
                    {
                        c = c + 1;
                    }
                }
                Console.WriteLine($"le 2 stringhe sono uguali fino al carattere numero {c}");
            }
            return n;
        }
        public static bool ContainsDoubleChar(string s)
        {
            bool n;
            if (s.Contains("A") || s.Contains("E") || s.Contains("I") || s.Contains("O") || s.Contains("U"))
            {
                n = true;
            }
            else
            {
                n = false;
            }
            return n;
        }
        public static string Convert(string s)
        {
            for(int i=0;i<s.Length;i++)
            {
                if(i==0)
                {
                    Char.ToUpper(s[i]);
                }
                if (s[i] ==' ')
                {
                    Char.ToUpper(s[i + 1]);
                }
                else
                {
                    Char.ToLower(s[i + 1]);
                }
            }
            return s;
        }
    }
}
