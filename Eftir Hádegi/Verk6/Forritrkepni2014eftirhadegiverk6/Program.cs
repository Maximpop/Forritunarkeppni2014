using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forritrkepni2014eftirhadegiverk6
{
    class Program
    {
        static void Main(string[] args)
        {
            int bull = Convert.ToInt32(Console.ReadLine());
            int sneidateljari = 0;
            int pizzur = 0;
            for (int i = 0; i < bull; i++)
            {
                sneidateljari += Convert.ToInt32(Console.ReadLine());

            }
            if ((sneidateljari% 8) ==0)
            {
                pizzur = sneidateljari / 8;
            }
            else
            {
                pizzur = sneidateljari / 8;
                pizzur += 1;
            }
            Console.WriteLine(pizzur);
            Console.ReadLine();
        }
    }
}
