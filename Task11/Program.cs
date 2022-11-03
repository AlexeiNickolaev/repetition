// Напишите программу, которая выводит случайное трехзначное число 
// и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из диапазона 100 - 999 => {number}");

// int firstDigit = number / 100;
// int secondDigit = number % 10;
// int num = firstDigit*10 + secondDigit;
// Console.WriteLine($"Если удалить вторую цифру числа {number}, то будет число {num}");

int TwoDigit(int num)
{
    int firstDigit = num / 100;
    int secondDigit = num % 10;
    return firstDigit*10 + secondDigit;
}
int result = TwoDigit(number);
Console.WriteLine($"Если удалить вторую цифру числа {number}, то будет число {result}");