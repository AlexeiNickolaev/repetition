// Напишите прогамму, которая на вход принимает два числа и выдает,
// какое число большее, а какое меньшее.
// a=5, b=7 -> max =7
// a=2, b=10 -> max = 10
// a=-9, b=-3 -> max = -3
Console.Write("Введите число a: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine($"Число {numberA} большее, {numberB} меньшее");
}
else
{
    Console.WriteLine($"Число {numberB} большее, {numberA} меньшее");
}
