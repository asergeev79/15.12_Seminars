// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
//
// m = 3, n = 4.
//
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int countRows = EnterNumber("Введите кол-во строк массива: ");
int countCols = EnterNumber("Введите кол-во столбцов массива: ");
int left = EnterNumber("Введите левую границу диапазона для случайных чисел: ");
int right = EnterNumber("Введите правую границу диапазона для случайных чисел: ");

if (!IsCorrectInput(left, right))
{
    Console.WriteLine("Левая граница должна быть меньше правой!");
}
else
{
    double[,] arrayDouble2D = CreateDoubleMatrix(countRows, countCols, left, right);
    Console.WriteLine($"Массив случайных вещественных чисел размером [{countRows} x {countCols}]:");
    PrintDoubleMatrix(arrayDouble2D);
}


int EnterNumber(string text) 
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

bool IsCorrectInput(int min, int max)
{
    return (min >= max) ? false : true;
}

double[,] CreateDoubleMatrix(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++) 
            matrix[i, j] = rnd.NextDouble() * (max - min) + min;
    return matrix;
}

void PrintDoubleMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        Console.Write($"[{matrix[i, 0],6:f1}");
        for (int j = 1; j < matrix.GetLength(1); j++) 
            Console.Write($" {matrix[i, j],6:f1}");
        Console.WriteLine(" ]");
    }
}

