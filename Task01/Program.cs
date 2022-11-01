/* Напишите прогамму, которая на вход принимает два числа и проверяет, 
является ли первое число квадратом второго.
a=25, b=5 -> да
a=2, b=10 -> нет
a=9, b=-3 -> да
ф=-3, b=9 -> нет
*/
Console.Write("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b * b)
{
    Console.WriteLine($"Число {a} Является квадратом числа {b}");
}
else
    Console.WriteLine($"Число {a} не является квадратом числа {b}");