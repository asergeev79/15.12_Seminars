// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
//
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты двух точек");
Console.Write("Введите координату x первой точки:");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y первой точки:");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z первой точки:");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату x второй точки:");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y второй точки:");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z второй точки:");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.Write($"Расстояние между точками A({x1},{y1},{z1}) и B({x2},{y2},{z2}) -> ");
Console.WriteLine($"{Rass(x1, y1, z1, x2, y2, z2):f2}");

double Rass(double xc1, double yc1, double zc1, double xc2, double yc2, double zc2)
{
    
    return Math.Sqrt((xc2 - xc1) * (xc2 - xc1) + (yc2 - yc1) * (yc2 - yc1) + (zc2 - zc1) * (zc2 - zc1));
}