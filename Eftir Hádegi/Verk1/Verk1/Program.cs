using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verk1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(' ');
            int x = Convert.ToInt32(text[0]);
            int y = Convert.ToInt32(text[1]);
            int z = Convert.ToInt32(text[2]);
            if (x <= y && y <= z)
            {
                Console.WriteLine("Milli");
            }
            else if(z <= y && y <= x)
            {
                Console.WriteLine("Milli");
            }
            else
            {
                Console.WriteLine("Ekki Milli");
            }
            Console.ReadLine();

        }
    }
}
