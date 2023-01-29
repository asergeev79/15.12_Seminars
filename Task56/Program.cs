// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
//
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
    Console.WriteLine("Исходный массив");
    PrintMatrix(array2D);
    int[] rowSum = GetArrayOfRowSum(array2D);
    Console.WriteLine("Массив с суммой по строкам");
    PrintMatrixWithColumn(array2D, rowSum);
    int posMinSum = GetFirstIndexWithMinSum(rowSum);
    Console.WriteLine($"Номер строки (первое вхождение) с наименьшей суммой элементов: {posMinSum + 1}");
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

void PrintMatrixWithColumn(int[,] matrix, int[] arr)
{
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        Console.Write($"{i + 1, 2}. [{matrix[i, 0], 5}");
        for (int j = 1; j < matrix.GetLength(1); j++) 
            Console.Write($", {matrix[i, j], 5}");
        Console.WriteLine($" ] = {arr[i]}");
    }
}

int GetRowSum(int[,] matrix, int row)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
        sum += matrix[row, j];
    return sum;
}

int[] GetArrayOfRowSum(int[,] matrix)
{
    int[] arr = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
        arr[i] = GetRowSum(matrix, i);
    return arr;
}

int GetFirstIndexWithMinSum(int[] arr)
{
    int min = arr[0];
    int indexMin = 0;
    for (int i = 1; i < arr.Length; i++)
        if (arr[i] < min)
        {
            min = arr[i];
            indexMin = i;
        }
    return indexMin;
}  