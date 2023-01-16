// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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
    PrintArray(array);
    ChangeSignArray(array);
    PrintArray(array);
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

void ChangeSignArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] *= (-1);  
}