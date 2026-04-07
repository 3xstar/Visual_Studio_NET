using System;
using System.Collections.Generic;
using System.Text;

namespace virtual_methods
{
    internal class task2
    {

        static void Sum(List<int> nums, out int sum)
        {
            sum = 0;

            foreach (int num in nums)
            {
                sum += num;
            }
        }

        static void Main(string[] args)
        {
            if(int.TryParse("6534", out int number))
            {
                Console.WriteLine(number);
            }

            int num;
            List<int> nums = new List<int>() { 1, 4, 5, 6 };
            Sum(nums, out num);
            Console.WriteLine(num);
        }
    }
}
