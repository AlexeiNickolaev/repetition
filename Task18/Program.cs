// Напишите прогрмму, которая по заданному номеру четверти,
// 1 показывает диапазон возможных координат точек в этой четверти(x и y)
Console.WriteLine("Задайте номер четверти: ");
string num = Console.ReadLine() ?? "0"; // цифры не нужны, поэтому строки

string result = Diapazon(num);
Console.WriteLine(result);

string Diapazon(string number)
{
    if (number == "1") return "x>1 и y>0";
    if (number == "2") return "x<0 и y>0";
    if (number == "3") return "x<1 и y<0";
    if (number == "4") return "x>0 и y<0";
    return "Ошибка ввода!";
}


