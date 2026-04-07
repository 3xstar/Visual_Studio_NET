using System;
using System.Collections.Generic;
using System.Text;

namespace ref_out
{
    internal class task1
    {
        static void InitializeArrayWithRef(ref int[] array, int size)
        {
            if(array != null)
            {
                Console.WriteLine($"Массив не пустой! Выдаем новый размер: {size}");
                array = new int[size];
            }
            else
            {
                Console.WriteLine("Массив пустой! Создаем новый массив");
                InitializeArrayWithOut(out array, size);
            }
        }

        static void InitializeArrayWithOut(out int[] array, int size)
        {
            array = new int[size];

            for(int i = 0; i < size; i++)
            {
                array[i] = i * i;
            }
            Console.WriteLine("Массив создан!\nКвадраты внутри массива: ");

            foreach(int i in array)
            {
                Console.WriteLine(i);
            }
        }

        static void Main2(string[] args)
        {
            int[] myArray = new int[2] { 10, 20 };
            Console.WriteLine("First method: ");
            InitializeArrayWithRef(ref myArray, 5);
            Console.WriteLine("Second method: ");
            InitializeArrayWithOut(out myArray, 5);

        }
    }
}
