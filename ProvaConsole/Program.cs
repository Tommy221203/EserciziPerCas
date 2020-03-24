using System;

namespace ProvaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string res;
            bool a;
            Console.WriteLine("Inserisci il primo valore:");
            string s1 = Console.ReadLine();
            a = EserciziPerCas.Class1.ContainsDoubleChar(s1);
            if (a == true)
                Console.WriteLine("la stringa contiene almeno una") ;
            res = EserciziPerCas.Class1.Convert(s1);
            Console.WriteLine($"la stringa corretta è {res}");
            Console.WriteLine("Inserisci il secondo valore:");
            string s2 = Console.ReadLine();
            a = EserciziPerCas.Class1.AreEquals(s1, s2);
            if (a == true)
                Console.WriteLine(0);
            else
            {
                int c=0;
                for (int i = 0; i < s1.Length; i++)
                {
                    if (s1[i] == s2[i])
                    {
                        c = c + 1;
                    }
                }
                Console.WriteLine($"le 2 stringhe sono uguali fino al carattere numero {c}");
            }


        }
    }
}
