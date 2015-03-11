using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forritkep2014efthadverk7
{
    class Program
    {
        static void Main(string[] args)
        {
            int staerd = Convert.ToInt32(Console.ReadLine());
            List<double> listi = new List<double>();
            bool haekandi = true;
            string[] text = Console.ReadLine().Split(' ');
            for (int i = 0; i < staerd; i++)
            {
                listi.Add(Convert.ToDouble(text[i]));
            }
            for (int i = 0; i < listi.Count - 1; i++)
            {
                if (listi[i] > listi[i +1])
                {
                    Console.WriteLine("Ekki haekkandi");
                    haekandi = false;
                    break;
                    
                }
            }
            if (haekandi)
            {
                Console.WriteLine("haekkandi");
            }
            Console.ReadLine();
        }
    }
}
