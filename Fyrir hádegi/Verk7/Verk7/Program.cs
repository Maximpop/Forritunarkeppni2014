using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verk7
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string output = null;
            for (int i = 0; i < input1.Length; i++)
            {
                output += input1[i].ToString() + input2[i].ToString();
            }
            Console.WriteLine(output);
            Console.ReadLine();
        }

    }
}
