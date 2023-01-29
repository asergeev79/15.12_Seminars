// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

int countRows = EnterNumber("Введите кол-во строк массива: ");
int countCols = EnterNumber("Введите кол-во столбцов массива: ");
int left = EnterNumber("Введите левую границу диапазона для случайных чисел: ");
int right = EnterNumber("Введите правую границу диапазона для случайных чисел: ");

int[,] array2D = CreateMatrix(countRows, countCols, left, right);
Console.WriteLine("Исходный массив");
PrintMatrix(array2D);

int[] array1D = Get1Dfrom2DArray(array2D);
Console.WriteLine("");
int[,] countSymbols = GetCountSymbols(array1D);
PrintMatrix(countSymbols);

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

// void PrintArray(int[] arr)
// {
//     Console.Write($"[{arr[0]}");
//     for (int i = 1; i < arr.Length; i++) 
//         Console.Write($",{arr[i]}");
//     Console.WriteLine("]");
// }

int[] Get1Dfrom2DArray(int[,] matrix)
{
    int size1DArray = matrix.GetLength(0) * matrix.GetLength(1);
    int[] array1Dfrom2D = new int[size1DArray];

    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array1Dfrom2D[i * matrix.GetLength(1) + j] = matrix[i, j];
        }
    
    return array1Dfrom2D;
}

int GetCountDifferentSymbols(int[] arr)
{
    int symbol = arr[0];
    int count = 1;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] != symbol)
        {
            symbol = arr[i];
            count++;
        }
    }
    return count;
}

int[,] GetCountSymbols(int[] arr)
{
    Array.Sort(arr);
    int[,] matrix = new int[GetCountDifferentSymbols(arr),2];
    int symbolPos = 0;
    matrix[0,0] = arr[0];
    matrix[0,1] = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == matrix[symbolPos,0])
        {
            matrix[symbolPos, 1]++;
        }
        else
        {
            symbolPos++;
            matrix[symbolPos, 0] = arr[i];
            matrix[symbolPos, 1] = 1;
        }
        matrix[symbolPos,0] = arr[i];

    }
    return matrix;
}