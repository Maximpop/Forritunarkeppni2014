using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verkefni11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            string[] s = Console.ReadLine().Split(' ');
            n = Convert.ToInt32(s[0]);
            m = Convert.ToInt32(s[1]);
            bool spegilmynd = true;

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < (line.Length-1)/2 && spegilmynd; j++)
                {
                    if (line[j] != line[line.Length - 1 - j])
                    {
                        spegilmynd = false;
                    }
                }
            }
            if (spegilmynd)
            {
                Console.WriteLine("Spegilmynd");

            }
            else
            {
                Console.WriteLine("Ekki spegilmynd");
            }


        }
    }
}
