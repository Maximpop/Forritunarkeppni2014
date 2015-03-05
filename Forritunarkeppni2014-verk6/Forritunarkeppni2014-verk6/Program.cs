using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forritunarkeppni2014_verk6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            bool seinasta = false;
            if ((n % 2) == 0)
            {
                for (int i = 0; i < n / 2; i++)
                {
                    for (int j = 0; j < n / 2; j++)
                    {
                        Console.Write("H");
                        Console.Write("S");
                    }
                    Console.WriteLine();
                    for (int x = 0; x < n / 2; x++)
                    {
                        Console.Write("S");
                        Console.Write("H");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                    for (int i = 0; i < (n / 2); i++)
                    {
                        for (int j = 0; j < (n / 2); j++)
                        {
                            Console.Write("H");
                            Console.Write("S");
                        }
                        Console.Write("H");
                        Console.WriteLine();
                        for (int x = 0; x < (n / 2); x++)
                        {
                            Console.Write("S");
                            Console.Write("H");
                            
                        }
                       
                            Console.Write("S");
                       
                        Console.WriteLine();
                    }
                    for (int j = 0; j < (n / 2); j++)
                    {
                        Console.Write("H");
                        Console.Write("S");
                    }
                    Console.Write("H");
            }
            Console.ReadLine();
        }
    }
}
