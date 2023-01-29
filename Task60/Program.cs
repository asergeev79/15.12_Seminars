// *Задача 60. Сформируйте трёхмерный массив 
// из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int count1D = EnterNumber("Введите размер первой координаты массива: ");
int count2D = EnterNumber("Введите размер второй координаты массива: ");
int count3D = EnterNumber("Введите размер третьей координаты массива: ");
// int left = EnterNumber("Введите левую границу диапазона для случайных чисел: ");
// int right = EnterNumber("Введите правую границу диапазона для случайных чисел: ");
int left =  10;
int right = 99;

if (!IsEnoughNumbers(count1D, count2D, count3D, left, right))
{
    Console.WriteLine("Диапазон случайных чисел должен быть больше размера массива!");
    return;
}

int[,,] array3DDifferentSymbols = CreateArray3D(count1D, count2D, count3D, left, right);
Console.WriteLine("Трёхмерный массив из неповторяющихся двузначных чисел:");
PrintArray3D(array3DDifferentSymbols);


int EnterNumber(string text) 
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

bool IsEnoughNumbers(int dimensionA, int dimensionB, int dimensionC, int min, int max)
{
    return (dimensionA * dimensionB * dimensionC < max - min) ? true : false;
}

bool IsNumberInArray(int[] arr, int num, int count)
{
    for (int i = 0; i < count; i++)
        if (num == arr[i]) return true;
    return false;
}

int[,,] CreateArray3D(int dimensionA, int dimensionB, int dimensionC, int min, int max)
{
    int[,,] newArray3D = new int[dimensionA, dimensionB, dimensionC];
    int[] ArrayOfDifferentNumbers = new int[dimensionA * dimensionB * dimensionC];
    int countDiffNumbers = 0;
    Random rnd = new Random();
    int nextRandomNum = 0;

    for (int i = 0; i < newArray3D.GetLength(0); i++)
        for (int j = 0; j < newArray3D.GetLength(1); j++) 
            for (int k = 0; k < newArray3D.GetLength(2); k++)
            {
                do {
                    nextRandomNum = rnd.Next(min, max + 1);
                } while (IsNumberInArray(ArrayOfDifferentNumbers, nextRandomNum, countDiffNumbers));
                ArrayOfDifferentNumbers[countDiffNumbers++] = nextRandomNum;
                newArray3D[i, j, k] = nextRandomNum;
            }
    return newArray3D;
}

void PrintArray3D(int[,,] arr3D)
{
    for (int i = 0; i < arr3D.GetLength(0); i++) 
    {
        Console.Write($"[");
        for (int j = 0; j < arr3D.GetLength(1); j++) 
            for (int k = 0; k < arr3D.GetLength(2); k++) 
                Console.Write($" {arr3D[i, j, k], 5}({i, 2},{j, 2},{k, 2})");
        Console.WriteLine(" ]");
    }
}
