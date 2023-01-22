// Задача 43: Напишите программу, 
// которая найдёт точку пересечения двух прямых, 
// заданных уравнениями 
// y = k1 * x + b1, 
// y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
//
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите коэффициенты уравнения прямой на плоскости вида y = kx + b");
double[] line1 = EnterLineCoef("первой");
double[] line2 = EnterLineCoef("второй");

if (IsLinesCross(line1[0], line2[0]))
{
    double[] pointCrossLine = FindCrossPoint(line1, line2);
    Console.WriteLine("Точка пересечения прямых:");
    Console.WriteLine($"{PrintLine(line1)}");
    Console.WriteLine($"{PrintLine(line2)}");
    Console.WriteLine($"-> {PrintPoint(pointCrossLine)}");
} else if (line1[1] != line2[1])
{
    Console.WriteLine("Прямые не пересекаются - параллельные");
} else
{
    Console.WriteLine("Прямые совпадают");
}

double EnterNumber(string text) 
{
    Console.WriteLine(text);
    return Convert.ToDouble(Console.ReadLine());
}

double[] EnterLineCoef(string text)
{
    double[] line = new double[2];
    line[0] = EnterNumber("Введите коэффициент k уравнения " + text + " прямой");
    line[1] = EnterNumber("Введите коэффициент b уравнения " + text + " прямой");
    return line;
}

string PrintLine(double[] lineCoef)
{
    string line = "y = ";
    if (lineCoef[0] == 0)
    {
        line += $"{lineCoef[1]}";
        return line;
    }
    string sign = "+";
    double b = lineCoef[1];
    if (lineCoef[0] == 1)
        line =  line + "x";
    else if (lineCoef[0] == -1)
    {
        line = line + "-x";
    } else
        line = (lineCoef[0] < 0) ? line + $"({lineCoef[0]}) * x" : line + $"{lineCoef[0]} * x";
    if (b == 0)
        return line;
    if (b < 0) 
    {
        sign = "-";
        b = -b;
    }
    line += $" {sign} {b}";
    return line;      
}

bool IsLinesCross(double k1, double k2)
{
    return (k1 != k2) ? true : false; 
}

double[] FindCrossPoint(double[] lineCoef1, double[] lineCoef2)
{
    double[] crossPoint = new double[2];
    crossPoint[0] = (lineCoef2[1] - lineCoef1[1]) / (lineCoef1[0] - lineCoef2[0]);
    crossPoint[1] = lineCoef1[0] * crossPoint[0] + lineCoef1[1];
    return crossPoint;
}

string PrintPoint(double[] point)
{
    return $"({point[0]}, {point[1]})";
}