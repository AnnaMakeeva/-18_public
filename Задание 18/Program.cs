using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку со скобками");

            string s = Console.ReadLine();

            Console.WriteLine("Результат 1 {0}", Program.Checkbrackets('(', ')', s));
            Console.WriteLine("Результат 2 {0}", Program.Checkbrackets('{', '}', s));
            Console.WriteLine("Результат 3 {0}", Program.Checkbrackets('[', ']', s));

            Console.ReadKey();
        }

        static bool Checkbrackets(char LB, char RB, string S)
        {
            
            char[] a = new char[S.Length];

            int i = 0;
            int ind = 0;

            while (i < S.Length)
            {
                if (S[i] == LB)
                {
                    a[ind] = LB;
                    ind++;
                }

                else if (S[i] == RB && ind > 0)
                {
                    ind--;
                }

                else if (S[i] == RB && ind == 0)
                {
                return false;
                }

            i++;
            }

            if (ind == 0) return true;
            else return false;

        }

    }
}
