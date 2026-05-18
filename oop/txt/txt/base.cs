namespace txt
{
    internal class @base
    {
        static void Main1(string[] args)
        {
            string path = @"C:\testProgram\test.txt";

            //создание файла
            if (!File.Exists(path)) //File.Exists(path) - существует ли фаил по этому пути
            {
                File.Create(path); //создать фаил
            }

            //запись в файл
            string text = "Hello world!";
            File.WriteAllText(path, text);

            File.AppendAllText(path, "How are you?"); //добавление текста в конец файла

            File.AppendAllLines(path, new string[] { "I am file", "And you?" }); //добавление строк в конец файла

            //чтение из файла
            string readText = File.ReadAllText(path); //чтение всего текста из файла
            Console.WriteLine(readText);

            File.Copy(path, @"C:\testProgram\testCopy.txt"); //копирование файла
            File.Delete(path); //удаление файла

            File.Move(@"C:\testProgram\testCopy.txt", @"C:\testProgram\testMoved.txt"); //перемещение файла
        }
    }
}
