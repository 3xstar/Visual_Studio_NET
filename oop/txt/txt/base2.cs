using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.IO;

namespace txt
{
    internal class base2
    {
        static void Main(string[] args)
        {
            FileInfo fileinfo = new FileInfo(@"C:\testProgram\test.txt");

            //запись в файл
            using (StreamWriter writter = fileinfo.CreateText())
            {
                while (true)
                {
                    string line = Console.ReadLine();
                    writter.WriteLine(line);
                    
                    if(line == "exit")
                    {
                        break;
                    }
                }
            }

            //чтение из файла
            using (StreamReader reader = fileinfo.OpenText())
            {
                string s = reader.ReadToEnd();
                Console.WriteLine(s);
            }
        }  
    }
}
