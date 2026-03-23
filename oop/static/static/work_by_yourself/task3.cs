namespace lesson2.work_by_yourself
{
    internal class task3
    {
        static void Main3(string[] args)
        {
            CurrencyConverter.SetRate(84);
            Console.WriteLine("10 долларов в рублях: " + CurrencyConverter.ConvertUsdToRub(10));
            Console.WriteLine("10000 рублей в долларах: " + CurrencyConverter.ConvertRubToUsd(10000));
        }
    }
    static class CurrencyConverter
    {
        static double usdToRubRate;

        public static double SetRate(double rate)
        {
            usdToRubRate = rate;
            return usdToRubRate;
        }

        public static double ConvertUsdToRub(double usd)
        {
            return usd * usdToRubRate;
        }

        public static double ConvertRubToUsd(double rubles)
        {
            return rubles / usdToRubRate;
        }
    }
}