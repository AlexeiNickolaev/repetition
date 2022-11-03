// Напишите программу, которая принимет на вход число 
// и проверяет, кратно ли оно одновременно 7 и 23
// 14 -> нет
// 46 -> нет
// 161 -> да

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number % 7 == 0 && number % 23 == 0)
//     Console.WriteLine("кратно");
// else Console.WriteLine("не кратно");

// bool CheckindNomber(int number, int div1, int div2)
// {
//     return number % div1 == 0 && number % div2 == 0;
// }
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// bool result=CheckindNomber(number, 7, 23);
// if (result)
// {
//     Console.WriteLine("да");
// }
// else Console.WriteLine("нет");

//еще одно решение

bool Remains(int a, int b)
{
    return a % b == 0;
}
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());    // универсальный метод

if (Remains(number, 7) && Remains(number, 23)) Console.WriteLine("да");
else Console.WriteLine("нет");