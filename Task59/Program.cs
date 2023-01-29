// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

int countRows = EnterNumber("Введите кол-во строк массива: ");
int countCols = EnterNumber("Введите кол-во столбцов массива: ");
int left = EnterNumber("Введите левую границу диапазона для случайных чисел: ");
int right = EnterNumber("Введите правую границу диапазона для случайных чисел: ");

int[,] array2D = CreateMatrix(countRows, countCols, left, right);
Console.WriteLine("Исходный массив");
PrintMatrix(array2D);

int minElement = GetMinInMatrix(array2D);
Console.WriteLine($"Минимальный элемента массива - {minElement}");

int[,] newArray2d = RemoveRowCol(array2D, minElement);
Console.WriteLine("Массив после удаления строк и столбцов,");
Console.WriteLine("на пересечении которых находятся");
Console.WriteLine("все вхождения минимального элемента");
PrintMatrix(newArray2d);

int EnterNumber(string text) 
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
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

int GetMinInMatrix(int[,] matrix)
{
    int minValue = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            if (matrix[i, j] < minValue)
                minValue = matrix[i, j];
    return minValue;
}

(int row, int col) GetFirstPosValue(int[,] matrix, int value)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            if (matrix[i, j] == value)
                return (i, j);
    return (-1, -1); // если элемента нет в массиве
}

// метод удаления первого вхождения элемента
// после удаления строки и столбца снова выывается метод с этим же элементом
int[,] RemoveRowCol(int[,] matrix, int value)
{
    var tuple = GetFirstPosValue(matrix, value);
    if (tuple.row == -1) return matrix; // условие выхода из рекурсии
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int rowMatrix = 0;
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (i == tuple.row) rowMatrix++;

        int colMatrix = 0;
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            newMatrix[i, j] = (j != tuple.col) ? matrix[rowMatrix, colMatrix] : matrix[rowMatrix, ++colMatrix];
            colMatrix++;
        }
        rowMatrix++;
    }
    return RemoveRowCol(newMatrix, value);
}
