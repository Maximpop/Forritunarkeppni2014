using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forritkepeftirhadverk10
{
    class Program
    {
        static void Main(string[] args)
        {
            int fjoldi = Convert.ToInt32(Console.ReadLine());
            List<string> listi = new List<string>();
            for (int i = 0; i < fjoldi; i++)
            {
                listi.Add(Console.ReadLine());
            }
            listi.Sort();
            foreach (var item in listi)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
