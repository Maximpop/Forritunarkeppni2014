using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forritunarkeppi2014_verk2
{
    class Program
    {
        static void Main(string[] args)
        {
            long tala = Convert.ToInt64(Console.ReadLine());
            if ((tala%2) == 0)
            {
                Console.WriteLine("Ég elska hana ekki");
            }
            else
            {
                Console.WriteLine("Ég elska hana");

            }
            Console.ReadLine();
        }
    }
}
