// Задача 58: Задайте две матрицы. 
// Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int left = EnterNumber("Введите левую границу диапазона для случайных чисел: ");
int right = EnterNumber("Введите правую границу диапазона для случайных чисел: ");

if (!IsCorrectInput(left, right))
{
    Console.WriteLine("Левая граница должна быть меньше правой!");
    return;
}

int rowsFirst = EnterNumber("Введите кол-во строк первого массива: ");
int colsFirst = EnterNumber("Введите кол-во столбцов первого массива: ");
int[,] matrixFirst = CreateMatrix(rowsFirst, colsFirst, left, right);
PrintMatrix(matrixFirst);

int rowsSecond = EnterNumber("Введите кол-во строк второго массива: ");
int colsSecond = EnterNumber("Введите кол-во столбцов второго массива: ");
int[,] matrixSecond = CreateMatrix(rowsSecond, colsSecond, left, right);
PrintMatrix(matrixSecond);

if (!IsMatrixCanMultiply(matrixFirst, matrixSecond))
{
    Console.WriteLine("Матрицы не могут быть перемножены, так как не удовлетворяют условию совместимости:");
    Console.WriteLine("Количество столбцов первой матрицы должно быть равно количеству строк второй.");
}
else
{
    int[,] matrixMultiply = GetMatrixMultiply(matrixFirst, matrixSecond);
    Console.WriteLine("Произведение матриц");
    PrintMatrix(matrixMultiply);
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

bool IsMatrixCanMultiply(int[,] matrixA, int[,] matrixB)
{
    return (matrixA.GetLength(1) == matrixB.GetLength(0)) ? true : false;
}

int[,] GetMatrixMultiply(int[,] matrixA, int[,] matrixB)
{
    int[,] newMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
        for (int j = 0; j < matrixB.GetLength(1); j++)
            newMatrix[i, j] = GetScalarMultiplyRowCol(matrixA, i, matrixB, j);
    return newMatrix;
}

int GetScalarMultiplyRowCol(int[,] matrA, int rowMatrA, int[,] matrB, int colMatrB)
{
    int value = 0;
    for (int i = 0; i < matrA.GetLength(1); i++)
        value += matrA[rowMatrA, i] * matrB[i, colMatrB];
    return value;
}    