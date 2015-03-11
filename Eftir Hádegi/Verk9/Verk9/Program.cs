using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verk9
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            int index = -1;
            for (int i = s2.Length; i > 0 && index == -1; i--)
            {
                string s = s2.Substring(0, i);
                if (s1.EndsWith(s))
                {
                    index = s1.LastIndexOf(s);
                }
            }
            if (index == -1)
            {
                Console.WriteLine(s1 + s2);
            }
            else
            {
                Console.WriteLine(s1.Substring(0, index) + s2);
            }
            Console.ReadLine();
        }
    }
}
