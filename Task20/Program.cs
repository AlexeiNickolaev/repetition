// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве
// A (3,6); B(2,1) -> 5,09
// A(7,-5); B(1,-1) -> 7,21
Console.WriteLine("Введите координаты");
Console.Write("Точки Ax: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Точки Ay: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Точки Bx: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Точки By: ");
int yb = Convert.ToInt32(Console.ReadLine());

double Distans(int x1, int y1, int x2, int y2)
{
    double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    return result;
}

double distans= Math.Round(Distans(xa, xb, ya, yb), 2, MidpointRounding.ToZero); 
Console.WriteLine(distans);