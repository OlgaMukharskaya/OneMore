﻿using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new int[10];
            for (int index = 0; index < Array.Length; index++)
            {
                Array[index] = index * index;
            }

            foreach (int item in Array)

            {
                Console.WriteLine(item);
            }

        }
    }
}


// [14.02.2022 17:08] 
//Создать массив размером 10 элементов, заполнить его квадратами индексов (в цикле), и вывести его содержимое на экран
