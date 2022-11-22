// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1,   y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



double FindX(int a1, int a2, int c1, int c2)
{
    double a= a2 - a1;
    double c = c1 - c2;
    double x = a/c;
    return x;
}

double FindY(int a1, int c1, double x)
{
    double y = c1 * x + a1;
    return y;
}

Console.Write("Введите значение B1:  ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение B2:  ");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение K1:  ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение K2:  ");
int k2 = Convert.ToInt32(Console.ReadLine());

double valueX = FindX(b1, b2, k1, k2);
double valueY = FindY(b1, k1, valueX);

Console.WriteLine();

if(b1 == b2) Console.WriteLine("Являются одной прямой");
else if(k1 == k2) Console.WriteLine("Прямые не пересекаются ");
else Console.WriteLine($"Точка пересечения двух прямых ({valueX};{valueY})");
