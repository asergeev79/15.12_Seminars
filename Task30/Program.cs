// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int number = EnterNumber("Введите число: ");
int[] array = new int[number];
FillArray(array);
PrintArray(array);

int EnterNumber(string text) 
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(2);
}

void PrintArray(int[] arr)
{
    Console.Write($"[{arr[0]}");
    for (int i = 1; i < arr.Length; i++) Console.Write($",{arr[i]}");
    Console.Write("]");
}