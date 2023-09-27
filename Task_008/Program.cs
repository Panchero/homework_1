﻿/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает 
все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Clear();
Console.WriteLine("Введите число N и программа покажет все целые числа в промежутке от 1 до N ");
int n;
Console.Write("Введите число: ");
while (!int.TryParse(Console.ReadLine(), out n)) // Проверка на ввод целого числа
{
    Console.Write("Ошибка ввода! Введите число: "); // сообщение, когда условие не выполняется
}
for (int i = 2; i <= n; i = i + 2)
    Console.Write(i + " ");
    Console.WriteLine(); // в таком случае не вываливается знак "процент" после вывода результата