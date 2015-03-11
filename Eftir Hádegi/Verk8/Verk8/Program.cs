using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verk8
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int teljari = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    teljari--;
                }
                if (input[i] == ')')
                {
                    teljari++;
                }
            }
            if (teljari == 0 && input[0] != ')' && input[input.Length-1] != '(')
            {
                Console.WriteLine("Ja");
            }
            else
            {
                Console.WriteLine("Nei");
            }
            Console.ReadLine();
        }
    }
}
