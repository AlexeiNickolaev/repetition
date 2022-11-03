// 1.Напишите программу, которая выводит случайное число из отрезка[10, 99] 
// 2.Показать наибольшую цифру числа.

// 78 -> 8
// 12 -> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из диапазона 10 - 99 => {number}");
// int firstDigit = number / 10; // 78 / 10 = 7 int только целое число
// int secondDigit = number % 10; // 78 % 10 = 8 остаток от деления

// if (firstDigit == secondDigit) Console.WriteLine($"Обе цифры числа {number} равные");
// else if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа: {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа: {secondDigit}");


int MaxDigit(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    // if (firstDigit > secondDigit) return firstDigit;
    // return secondDigit;
    // или
    // return firstDigit > secondDigit ? firstDigit : secondDigit; // ?тогда  :иначе
    // или
    int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return result;
}
int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа: {maxDigit}");