using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForritunarKeppni2014Verk5
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            bool fyndid = true;
            for (int i = 0; i < text.Length-1; i++)
            {
                if (text[i] > text[i+1])
                {
                    fyndid = false;
                }
            }
            if (fyndid)
            {
                Console.WriteLine("fyndið");

            }
            else
            {
                Console.WriteLine("ekki fyndið");
            }
            Console.ReadLine();

        }
    }
}
