﻿/*----------------------------------------------------------------------------------------------------------------------
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
----------------------------------------------------------------------------------------------------------------------*/

int SplitNum(int x)
{
    int res = x%100/10; 
    return res;
}

Console.WriteLine("Добро пожаловать в программу нахождения второй цифры трехзначных чисел");

int x = new Random().Next(100,1000);
int res = SplitNum(x);
Console.WriteLine($"В трехзначном числе {x} вторая цифра - {res}");