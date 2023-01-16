// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int size = EnterNumber("Введите размер массива: ");
int left = EnterNumber("Введите левую границу диапазона для случайных чисел: ");
int right = EnterNumber("Введите правую границу диапазона для случайных чисел: ");
int number = EnterNumber("Введите искомое число: ");

if (!IsCorrectInput(left, right))
{
    Console.WriteLine("Левая граница должна быть меньше правой!");
}
else
{
    int[] array = CreateArray(size, left, right);
    PrintArray(array);
    string isNumber = IsNumberInArray(array, number) ? "присутствует" : "не присутствует";
    Console.WriteLine($"Число {number} {isNumber} в массиве");
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

bool IsNumberInArray(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
            return true;
    }
    return false;
}