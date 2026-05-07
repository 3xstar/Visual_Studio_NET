using System;
using System.Collections.Generic;
using System.Text;

namespace linq
{
    internal class base2
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            numbers = numbers.Append(5).ToArray();
            bool isNumber = numbers.Contains(5);
            bool grade18 = numbers.All(n => n > 18);
            bool grade18Any = numbers.Any(n => n > 18);

            int[] uniqueNumbers = numbers.Distinct().ToArray();

            int[] maxNumbers = numbers.OrderBy(n => n).Take(5).ToArray();
            int[] allNumbersGrade3 = numbers.Where(n => n > 3).ToArray();
        }
    }
}
