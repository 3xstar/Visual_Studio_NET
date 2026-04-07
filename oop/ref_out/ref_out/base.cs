namespace ref_out
{
    internal class @base
    {
        static void square(ref int number)
        {
            number = number * number;
        }

        static void squareList(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = numbers[i] * numbers[i];
            }
        }
        //ref - ссылка на объект
        //out - модификатор, который возвращает переменную

        //функция конвертации чисел
        static bool ValuteConverter(string name, int count, out int answer)
        {
            string[] valutes = { "USD", "EUR", "YUAN"};
            int[] courses = { 30, 40, 5 };

            if (valutes.Contains(name))
            {
                int current_courses = courses[new List<string>(valutes).IndexOf(name)];
                answer = count / current_courses;
                return true;
            }
            else
            {
                answer = 0;
                return false;
            }
        }


        static void Main1(string[] args)
        {
            int num = 10;
            List<int> numbers = new List<int>() { 1,2,3,4,5,6};

            square(ref num);
            squareList(numbers);

            Console.WriteLine(num);
            foreach(int i in numbers)
            {
                Console.Write(i);
            }

            Console.WriteLine();

            string str_num = "12323";
            if (int.TryParse(str_num, out int number))
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Это не число");
            }

            if (ValuteConverter("YUAN", 2000, out int answer)) Console.WriteLine(answer);
            else Console.WriteLine("Нет такой валюты");
        }
    }
}
