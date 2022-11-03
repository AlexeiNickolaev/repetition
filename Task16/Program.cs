// Напишите программу, которая принимет на вход два числа 
// и проверяет, является ли одно число квадратом второго
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8, 9 -> нет

bool Square(int number1, int number2)
{
    return number1 == number2 * number2 || number2 == number1 * number1;
}
Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());


if (Square(number1, number2))Console.WriteLine("Да");
else Console.WriteLine("Нет");