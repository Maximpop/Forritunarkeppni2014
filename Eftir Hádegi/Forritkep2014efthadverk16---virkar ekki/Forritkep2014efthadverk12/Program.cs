using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forritkep2014efthadverk12
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int svigi = 0;
            int hornklofi = 0;
            int slaufusvigi = 0;
            bool fyrsta = true;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '(')
                {
                    svigi += 1;
                }
                if (text[i] == ')')
                {
                    svigi -= 1;
                }
                if (text[i] == '{')
                {
                    svigi += 1;
                }
                if (text[i] == '}')
                {
                    svigi -= 1;
                }
                if (text[i] == '[')
                {
                    svigi += 1;
                }
                if (text[i] == ']')
                {
                    svigi -= 1;
                }

                if (svigi == -1  || hornklofi == -1 || slaufusvigi == -1 && fyrsta)
	            {
		            break;
                    fyrsta = false;
	               }
            }
            if (hornklofi == 0 && svigi == 0 && slaufusvigi == 0)
            {
                Console.WriteLine("Ja");
            }
            else
	{
                Console.WriteLine("Nei");
	}
            Console.ReadLine();

        }
    }
}
