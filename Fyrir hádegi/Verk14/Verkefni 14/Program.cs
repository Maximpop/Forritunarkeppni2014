using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verkefni_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //herna er feitt fkn comment
            int n = Convert.ToInt32(Console.ReadLine());
            double oldX =0, oldY = 0 , x= 0 , y = 0, distance = 0;
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    string[] s = Console.ReadLine().Split(' ');
                    oldX = Convert.ToDouble(s[0]);
                    oldY = Convert.ToDouble(s[1]);
                }
                else
                {
                    string[] s = Console.ReadLine().Split(' ');
                    x = Convert.ToDouble(s[0]);
                    y = Convert.ToDouble(s[1]);

                    double difx = x - oldX;
                    double dify = y - oldY;
                    distance += Math.Sqrt(difx * difx + dify * dify);
                    oldX = x;
                    oldY = y;
                }
            }
            Console.WriteLine(distance);
            Console.ReadLine();
        }
    }
}
