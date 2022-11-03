// Напишите программу, которая принимет на вход трехзначное число 
// и на выходе показывает вторую цифру этого числа
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine()); 

// int sekondnum= number%100/10;
// Console.WriteLine(sekondnum);

int SecondDigit(int number)
{
    int sekondnum = number / 10 % 10;
    return sekondnum;
}
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 99 || number > 999)
    Console.WriteLine("Вы ввели не трехзнчное число, попробуйте еще раз!");
else
{
    int result = SecondDigit(number);
    Console.WriteLine($"Вторая цифра числа {number} будет {result}");
}