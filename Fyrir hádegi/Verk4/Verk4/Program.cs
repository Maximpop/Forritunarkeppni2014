using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verk4
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            Console.Write(input + "! = ");
            for (int i = 1; i < input; i++)
            {
                Console.Write(i + " x ");
            }
            Console.Write(input);
            Console.ReadLine();
        }
    }
}
