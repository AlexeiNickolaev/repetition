// Наишите программу, которая 
// 1.принимает на вход координаты точки (X и Y), причем X!=0 и Y!=0 и 
// 2.выдает номер четверти плоскости, в которой находится эта точка

Console.WriteLine("Введите координаты");
Console.Write("точки X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("точки Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(x, y);
string result = quarter > 0 ? $"Указанные координаты соответствуют четверти {quarter}"
                           : "Введены некорректные данные";
Console.WriteLine(result);

int Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return 1;
    if (xc < 0 && yc > 0) return 2;
    if (xc < 0 && yc < 0) return 3;
    if (xc > 0 && yc < 0) return 4;
    return 0;
}
