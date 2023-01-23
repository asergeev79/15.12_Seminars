// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int countRows = EnterNumber("Введите кол-во строк массива: ");
int countCols = EnterNumber("Введите кол-во столбцов массива: ");
// int left = EnterNumber("Введите левую границу диапазона для случайных чисел: ");
// int right = EnterNumber("Введите правую границу диапазона для случайных чисел: ");

// if (!IsCorrectInput(left, right))
// {
//     Console.WriteLine("Левая граница должна быть меньше правой!");
// }
// else
// {
    int[,] array2D = CreateMatrix(countRows, countCols);
    Console.WriteLine("В массиве");
    PrintMatrix(array2D);
// }


int EnterNumber(string text) 
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

// bool IsCorrectInput(int min, int max)
// {
//     return (min >= max) ? false : true;
// }

int[,] CreateMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++) 
            matrix[i, j] = i + j;
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

