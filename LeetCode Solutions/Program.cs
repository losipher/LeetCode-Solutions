using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            Solutions sol = new Solutions();
            int[] nums = new int[3] { 1, 0, 1 };
            Console.WriteLine(sol.SingleNumber(nums));
        }
    }
}
