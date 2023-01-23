// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
//
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
    int[,] array2D = CreateMatrix(countRows, countCols, left, right);
    Console.WriteLine("В массиве");
    PrintMatrix(array2D);
    double[] arrayAverage = GetAverageInColumns(array2D); 
    Console.WriteLine("Среднее арфиметическое каждого столбца:");
    PrintDoubleArray(arrayAverage);    
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

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++) 
            matrix[i, j] = rnd.Next(min, max + 1);
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        Console.Write($"[{matrix[i, 0], 5}");
        for (int j = 1; j < matrix.GetLength(1); j++) 
            Console.Write($", {matrix[i, j], 5}");
        Console.WriteLine(" ]");
    }
}

void PrintDoubleArray(double[] arr)
{
    Console.Write($"[{arr[0]:f1}");
    for (int i = 1; i < arr.Length; i++) 
        Console.Write($"; {arr[i]:f1}");
    Console.WriteLine("]");
}

double[] GetAverageInColumns(int[,] matrix)
{
    double[] averageColumns= new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int sumColumn = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
            sumColumn += matrix[i, j];

        // (double)sum - приведение суммы целых чисел к вещественному типу
        // для получения вещественного результата деления
        averageColumns[j] = (double)sumColumn / matrix.GetLength(0); 
    }
    return averageColumns;
}