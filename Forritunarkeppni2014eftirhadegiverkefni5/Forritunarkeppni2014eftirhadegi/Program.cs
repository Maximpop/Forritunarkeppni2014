using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forritunarkeppni2014eftirhadegi
{
    class Program
    {
        static void Main(string[] args)
        {
            int tala = Convert.ToInt32(Console.ReadLine());
            int dagur = 0, klukkustund = 0, minuta = 0;

            if ((tala / 86400) > 1)
            {
                dagur = tala / 86400;
                tala = tala - (dagur * 86400);
            }
            if ((tala / 3600) > 1)
            {
                klukkustund = tala / 3600;
                tala = tala - (klukkustund * 3600);
            }
            if ((tala / 60) > 1)
            {
                minuta = tala / 60;
                tala = tala - (minuta * 60);
            }
            
            int sek = tala;

            Console.WriteLine(dagur + "  " + klukkustund + "  " + minuta + "  " + sek);
            Console.ReadLine();
        }
    }
}
