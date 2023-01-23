// Задача 50. Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
//
// Например, задан массив:
//
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//
// 1, 7 -> такого элемента в массиве нет

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
    int indexRow = EnterNumber("Введите позицию строки искомого элемента: ");
    int indexCol = EnterNumber("Введите позицию столбца искомого элемента: ");
    if (IsElementInMatrix(array2D, indexRow, indexCol))
    {
        Console.WriteLine($"на позиции [{indexRow}, {indexCol}]"); 
        Console.WriteLine($"находится элемент {array2D[indexRow, indexCol]}");
    }
    else
    {
        Console.WriteLine($"на позиции [{indexRow}, {indexCol}] элемента нет"); 
    }
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

bool IsElementInMatrix(int[,] matrix, int positionRow, int positionColumn)
{
    // если позиция по строке за пределами размерности матрицы по строке, то сразу false
    if (positionRow < 0 || positionRow > matrix.GetLength(0)) 
        return false;
    // если позиция по столбцу за пределами размерности матрицы по столбцу, тоже false
    if (positionColumn < 0 || positionColumn > matrix.GetLength(1))
        return false;
    // в ином случае обе позиции в пределах размерности матрицы
    return true;
}