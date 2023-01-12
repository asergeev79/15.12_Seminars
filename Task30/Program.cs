// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int size = EnterNumber("Введите размер массива: ");
int[] array = new int[size];
int right = EnterNumber("Введите правую границу диапазона для случайных чисел: ");
FillArray(array, right);
PrintArray(array);

int EnterNumber(string text) 
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(num + 1);
}

void PrintArray(int[] arr)
{
    Console.Write($"[{arr[0]}");
    for (int i = 1; i < arr.Length; i++) Console.Write($",{arr[i]}");
    Console.Write("]");
}