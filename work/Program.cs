﻿/*
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
["Hello", "2", "world", ":-)"] → [“2”, “:-)”]
["1234", "1564", "-2", "computer science"] → [“-2”]
["Russia", "Denmark", "Kazan"] → []

*/

string[] arr = { "Hello", "2", "world", ":-)"};

    string[] new_arr = new string[arr.Length];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4)
        {
            new_arr[count]=arr[i];
            count++;
        }
    }


    for (int i = 0; i < new_arr.Length; i++)
    {
        Console.Write($"{new_arr[i]} ");
    }
    Console.WriteLine();