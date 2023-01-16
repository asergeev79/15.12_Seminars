// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
//
// [3 7 22 2 78] -> 76
// ----------------------------------------------------------------------

int size = EnterNumber("Введите размер массива: ");
int minSizeArray = 2;
if (!IsCorrectSize(size, minSizeArray))
{
    Console.WriteLine($"Введите размер массива больше {minSizeArray - 1}");
    return;
}

int left = EnterNumber("Введите левую границу диапазона для случайных чисел: ");
int right = EnterNumber("Введите правую границу диапазона для случайных чисел: ");

if (!IsCorrectInput(left, right))
{
    Console.WriteLine("Левая граница должна быть меньше правой!");
    return;
}

double[] array = CreateDoubleArray(size, left, right);
double min = MinDoubleArray(array);
double max = MaxDoubleArray(array);
Console.WriteLine("Массив:");
PrintDoubleArray(array);
Console.WriteLine("Разница между максимальным и минимальным элементов массива:");
Console.WriteLine($"{max:f2} - {min:f2} = {(max - min):f2}");

int EnterNumber(string text) 
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

double[] CreateDoubleArray(int sizeArr, int numA, int numB)
{
    double[] arr = new double[sizeArr];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++) 
        arr[i] = rnd.NextDouble() * (numB - numA) + numA;
    return arr;
}

void PrintDoubleArray(double[] arr)
{
    Console.Write($"[{arr[0]:f2}");
    for (int i = 1; i < arr.Length; i++) 
        Console.Write($"; {arr[i]:f2}");
    Console.WriteLine("]");
}

bool IsCorrectInput(int numA, int numB)
{
    return (numA >= numB) ? false : true;
}

bool IsCorrectSize(int num, int sizeMin)
{
    return (num < sizeMin) ? false : true;
}

// Метод нахождения минимального элемента массива
double MinDoubleArray(double[] arr)
{
    double minElement = arr[0];
    for (int i = 1; i < arr.Length; i++)
        if (arr[i] < minElement) 
            minElement = arr[i];
    return minElement;
}

// Метод нахождения максимального элемента массива
double MaxDoubleArray(double[] arr)
{
    double maxElement = arr[0];
    for (int i = 1; i < arr.Length; i++)
        if (arr[i] > maxElement) 
            maxElement = arr[i];
    return maxElement;
}
