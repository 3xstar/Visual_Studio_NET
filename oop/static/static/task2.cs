namespace lesson2
{
    internal class task2
    {
        static void Main2(string[] args)
        {
            Logger.Log("Вход в аккаунт");
            Logger.Log("Выход из аккаунта");
            Logger.Log("Вход в аккаунт");

            Logger.ShowLog();
            Console.WriteLine(Logger.description);
            Console.WriteLine(Logger.logsize);
        }
    }

    static class Logger
    {
        public const int logsize = 10;

        public static readonly string description = "gsaf";

        static List<string> logEntries = new List<string>();

        public static void Log(string message)
        {
            logEntries.Add(message);
        }

        public static void ShowLog()
        {
            foreach (string log in logEntries)
            {
                Console.WriteLine(log);
            }
        }
    }
}
