// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
//
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int size = EnterNumber("Введите количество вводимых чисел: ");
int minSizeArray = 1;
if (!IsCorrectSize(size, minSizeArray))
{
    Console.WriteLine($"Введите размер массива больше {minSizeArray - 1}");
    return;
}

int[] array = CreateArray(size);
int countNums = CountNumbersLargerZero(array);
Console.WriteLine("В введённых числах:");
PrintArray(array);
Console.WriteLine($"{countNums} чисел, больше нуля");

int EnterNumber(string text) 
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

bool IsCorrectSize(int num, int sizeMin)
{
    return (num < sizeMin) ? false : true;
}

int[] CreateArray(int sizeArr)
{
    int[] arr = new int[sizeArr];
    for (int i = 0; i < arr.Length; i++) 
        arr[i] = EnterNumber($"Введите {i + 1}-ое число: ");
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write($"{arr[0]}");
    for (int i = 1; i < arr.Length; i++) 
        Console.Write($",{arr[i]}");
    Console.WriteLine("");
}

int CountNumbersLargerZero(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] > 0) 
            count++;
    return count;
}