// Напишите программу, которая на вход принимает одно число N? 
// а на выходе показывает все целые числа в промежутке от -N до N
// 3 -> "-3, -2, -1, 0, 1, 2, 3"
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Все целые числа от {-number} до {number}: ");

int counter = -number;
while (counter <= number)
{
    Console.Write($"{counter} ");
    counter++;
}
