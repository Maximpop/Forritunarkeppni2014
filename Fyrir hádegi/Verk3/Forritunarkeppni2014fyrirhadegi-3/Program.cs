using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forritunarkeppni2014fyrirhadegi_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            bool boole = true;
            int teljari = 0;
            if (text.Length > 1000)
            {
                Console.WriteLine("Villa");
                boole = false;
            }
            for (int i = 0; i < text.Length && boole; i++)
            {
                if (text[i] == '+')
                {
                    teljari++;
                }
            }
            if (boole)
            {
                Console.WriteLine(teljari);
            }
            Console.ReadLine();
        }
    }
}
