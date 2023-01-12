// Задача 29: Напишите программу, 
// которая задаёт массив из 8 элементов 
// и выводит их на экран.
//
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
// --------------------------------------------------------------

int size = EnterNumber("Введите размер массива: ");
int[] array = new int[size];
int left = EnterNumber("Введите левую границу диапазона для случайных чисел: ");
int right = EnterNumber("Введите правую границу диапазона для случайных чисел: ");

if (!IsCorrectInput(left, right))
{
    Console.WriteLine("Границы диапазона должны быть положительными и левая граница меньше правой!");
}
else
{
    FillArray(array, left, right);
    PrintArray(array);
}

int EnterNumber(string text) 
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] arr, int numA, int numB)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++) 
        arr[i] = rnd.Next(numA, numB + 1);
}

void PrintArray(int[] arr)
{
    Console.Write($"[{arr[0]}");
    for (int i = 1; i < arr.Length; i++) 
        Console.Write($",{arr[i]}");
    Console.Write("]");
}

bool IsCorrectInput(int numA, int numB)
{
    return (numA < 0 || numB < 0 || numA >= numB) ? false : true;
}