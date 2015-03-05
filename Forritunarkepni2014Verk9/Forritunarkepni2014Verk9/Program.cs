using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forritunarkepni2014Verk9
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = null;
            for (int i = 0; i < input.Length -1; i++)
            {
                if (input[i] != input[i+1] )
                {
                    output += input[i];
                }
            }
            
                output += input[input.Length-1];
            
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
