// Напишите прогамму, которая на вход принимает число N, 
// а на выходе показывает все четные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.Write($"Все четные числа от 1 до {numberN}: ");

int count = 2;
while (count <= numberN)
{
    Console.Write($"{count} ");
    count = count + 2;
}