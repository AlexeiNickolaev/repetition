﻿// Напишите прогамму, которая на вход принимает три числа и выдает макимальное из этих чесел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 ->  22
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;
if (number1 > max) max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;

Console.WriteLine($"Максимальное число: {max}");
