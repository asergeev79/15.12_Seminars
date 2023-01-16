// Задача 34: Задайте массив, 
// заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
//
// [345, 897, 568, 234] -> 2
// -----------------------------------------------------------------------

int size = EnterNumber("Введите размер массива: ");
int left = 100, right = 1000;

int[] array = CreateArray(size, left, right);
int[] evenArray = CountEvenInArray(array);

Console.WriteLine("Количество чётных чисел в массиве случайных положительных трёхзначных чисел:");
PrintArray(array);
Console.WriteLine($"-> {evenArray.Length}");
Console.WriteLine("Массив чётных чисел из изначального массива:");
PrintArray(evenArray);

int EnterNumber(string text) 
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int sizeArr, int numA, int numB)
{
    int[] arr = new int[sizeArr];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++) 
        arr[i] = rnd.Next(numA, numB + 1);
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write($"[{arr[0]}");
    for (int i = 1; i < arr.Length; i++) 
        Console.Write($",{arr[i]}");
    Console.WriteLine("]");
}

int[] CountEvenInArray(int[] arr)
{
    int count = 0;
    int[] arrNew = new int[count];
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] % 2 == 0)
        {
            count++;
            Array.Resize(ref arrNew, count); // Погуглил метод изменения размера массива
            arrNew[count - 1] = arr[i];
        } 
    return arrNew;
}
