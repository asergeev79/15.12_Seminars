// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

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
    int sumDiag = SumMainDiag(array2D);
    Console.WriteLine($"Сумма чисел на главной диагонали равна: {sumDiag}");
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

int SumMainDiag(int[,] matrix)
{
    int sum = 0;
    int count = (matrix.GetLength(0) <= matrix.GetLength(1)) ? matrix.GetLength(0) : matrix.GetLength(1);
    for (int i = 0; i < count; i++)
        sum += matrix[i, i];
    return sum;
}