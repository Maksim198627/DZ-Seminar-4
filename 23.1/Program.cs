﻿// Задача 29: Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры
//  и далее выводит массив на экран в одну строку.

//Говорим пользователю что нужно сделать
//Задаем массив на 8 элементов.
//Создаем функцию на последовательный ввод всех 8 элементов массива (внутри цикл for).
//Выводим массив на экран в строку.

System.Console.WriteLine("Ниже необходимо ввести массив");
int[] array = InputArray(); //Создаем массив
System.Console.Write("Введеный массив: ");

// Создаем функцию для ввода массива
int[] InputArray()
{
    int[] res = new int[8];

    for (int i = 0; i < 8; i++)
    {
        System.Console.Write($"Ведите {i + 1}-й элемент массива: ");
        res[i] = Convert.ToInt32(Console.ReadLine()!);
    }

    return res;
}
//Выводим массив в строку
for (int i = 0; i < array.Length; i++)
    System.Console.Write(array[i]);

System.Console.Write("Для продолжения нажмите любую клавишу: ");
Console.ReadKey();
