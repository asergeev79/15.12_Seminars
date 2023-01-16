// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int size = EnterNumber("Введите размер массива: ");
int left = EnterNumber("Введите левую границу диапазона для случайных чисел: ");
int right = EnterNumber("Введите правую границу диапазона для случайных чисел: ");

if (!IsCorrectInput(left, right))
{
    Console.WriteLine("Левая граница должна быть меньше правой!");
}
else
{
    int[] array = CreateArray(size, left, right);
    Console.WriteLine("В массиве");
    PrintArray(array);
    PrintArray(MultiplyElementsInArray(array));
}

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

bool IsCorrectInput(int numA, int numB)
{
    return (numA >= numB) ? false : true;
}

int[] MultiplyElementsInArray(int[] arr)
{
    int sizeNew = (arr.Length % 2 == 0) ? arr.Length / 2 : arr.Length / 2 + 1;
    int[] arrNew = new int[sizeNew];
    if (arr.Length % 2 != 0) arrNew[arrNew.Length - 1] = arr[arr.Length / 2];
    for (int i = 0; i < arr.Length / 2; i++)
    {
        arrNew[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    return arrNew;
}