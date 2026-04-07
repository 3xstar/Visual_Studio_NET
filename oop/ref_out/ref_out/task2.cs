using System;
using System.Collections.Generic;
using System.Text;

namespace ref_out
{
    internal class task2
    {
        static void Swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
        
        static void Main(string[] args)
        {
            int a = 50;
            int b = 100;
            Console.WriteLine($"a =  {a}\nb = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"SWAP!");
            Console.WriteLine($"a =  {a}\nb = {b}");
        }
    }
}
