using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verk13
{
    class Program
    {
        static void Main(string[] args)
        {
            bool booool = true;
            string text = Console.ReadLine();
            List<int> tala = new List<int>();
            int output = 0;
            foreach (var item in text)
            {
                tala.Add(Convert.ToInt32(item.ToString()));
            }
            if (tala.Count >= 2)
            {
                Console.WriteLine(text);
            }
            output = tala.Sum();
            Console.WriteLine(output);

            while (output >= 10)
            {
                tala.Clear();
                text = output.ToString();
                foreach (var item in text)
                {
                    tala.Add(Convert.ToInt32(item.ToString()));
                }
                output = tala.Sum();
                Console.WriteLine(output);
            }
            Console.ReadLine();
        }
    }
}
