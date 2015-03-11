using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verk11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int>[] buckets = new List<int>[10];

            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                buckets[i] = new List<int>();
            }
            int[] nums = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            for (int i = 0; i < n; i++)
            {
                buckets[nums[i] / 10].Add(nums[i] % 10);
            }

            for (int i = 0; i < 10; i++)
            {
                if (buckets[i].Count == 0)
                {
                    continue;
                }
                buckets[i].Sort();
                Console.Write(i + " ");
                buckets[i].ForEach(x => Console.Write(x));
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
