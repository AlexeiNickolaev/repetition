﻿// Написать программу, которая на вход принимает число и выдает его квадрат
// (число умноженное на само себя)
// 4->16
// 3->9
// 7->49

Console.WriteLine("Введите целое число: ");
int number=Convert.ToInt32(Console.ReadLine());
int square=number*number;
Console.WriteLine($"Квадрат числа {number} равен {square}");
