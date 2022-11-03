// Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.


int ThirdNumber(int number)
{
    int result = 0;
    while (number > 1000)
    {
        number /= 10;
    }   
    result = number % 10;
    return result;
}
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99) 
{
    int digit = ThirdNumber(number);
    System.Console.WriteLine($"Третья цифра числа {number} -> {digit}");
}

else System.Console.WriteLine($"У числа {number} -> третьей цифры нет");