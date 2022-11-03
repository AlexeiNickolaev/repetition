// Напишите программу, которая принимет на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// Console.WriteLine("Введите цифру, обозначающую день недели: ");
// int day = Convert.ToInt32(Console.ReadLine());

// if (day==6||day==7)
// Console.WriteLine("Выходной");
// else if (day>0&& day <6)
// Console.WriteLine("Рабочий день");
// else
// Console.WriteLine("Такого дня недели нет!");

string Weekend(string num)
{
    if (num == "6" || num == "7")return "Выходной день";
    if (num=="1")return "Рабочий день";
    if (num=="2")return "Рабочий день";
    if (num=="3")return "Рабочий день";
    if (num=="4")return "Рабочий день";
    if (num=="5")return "Рабочий день";
    return "Неверное значение!";
}

Console.WriteLine("Введите цифру, обозначающую день недели: ");
string day = Console.ReadLine() ?? "0";

string result = Weekend(day);
Console.WriteLine(result);
