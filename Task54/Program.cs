// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
    SortEachRowMatrix(array2D);
    Console.WriteLine("Массив после сотрировки каждой строки по убыванию");
    PrintMatrix(array2D);
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

void SortRowInMatrix(int[,] matrix, int row)
{
    for (int i = 0; i < matrix.GetLength(1) - 1; i++)
        for (int j = i + 1; j < matrix.GetLength(1); j++)
            if (matrix[row, j] > matrix[row, i])
            {
                int temp = matrix[row, j];
                matrix[row, j] = matrix[row, i];
                matrix[row, i] = temp;
            }
}

void SortEachRowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        SortRowInMatrix(matrix, i);
}