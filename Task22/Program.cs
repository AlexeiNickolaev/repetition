// Напишите программу, которая принимает на вход число N 
// и выдает таблицу квадратов чисел от 1 до N
// 5 -> 1, 4, 9, 16,25
// 2 -> 1, 4


void Square(int number)
{
    int counter = 1;
    while (counter <= number)
    {
        Console.WriteLine($"Число {counter} квадрат {counter * counter}");
        counter++;
    }
}

Console.WriteLine("Введите чмсло N: ");
int num = Convert.ToInt32(Console.ReadLine());
Square(num);

// while (counter<=numberN)
// {
//     res=counter*counter;
//     Console.WriteLine($"Число {counter} квадрат {res}");
//     counter++;
// }

