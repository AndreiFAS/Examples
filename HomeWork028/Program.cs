﻿// Задача 72: Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел (без разделителя). 
// В массиве data хранится информация о количестве бит, которые занимают числа из массива info. 
// Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.
// Пример:
// входные данные:
// data = {0, 1, 1, 1, 1, 0, 0, 0, 1 } info = {2, 3, 3, 1 }
// выходные данные: 1, 7, 0, 1
// Комментарий: первое число занимает 2 бита (01 -> 1); второе число занимает 3 бита (111 -> 7); третье число занимает 3 бита (000 -> 0; четвёртое число занимает 1 бит (1 -> 1)

int[] data = { 0, 1, 1, 0, 1, 1, 1, 0, 1, 0, 0, 1 };
int[] info = { 4, 3, 4, 1 };

int index = 0;
string number = string.Empty;

foreach (int value in info)
{
    number = "";

    for (int i = 0; i < value; i++)
    {
        number += data[index];
        index++;
    }

    int newNumber = Convert.ToInt32(number, 2);
    Console.Write(newNumber + " ");
}