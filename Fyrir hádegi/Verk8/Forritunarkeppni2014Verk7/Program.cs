using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forritunarkeppni2014Verk7
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string text1 = null;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLower(text[i]))
                {
                    text1 += char.ToUpper(text[i]);
                }
                else if(char.IsUpper(text[i]))
                {
                    text1 += char.ToLower(text[i]);
                }
                else
                {
                    text1 += text[i];
                }
            }
            Console.WriteLine(text1);
            Console.ReadLine();
            
        }
    }
}
