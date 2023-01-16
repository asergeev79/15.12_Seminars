// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
//
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// --------------------------------------------------------------------

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

int[] array = CreateArray(size, left, right);
int[] arrayOddPosition = OddPositionArray(array);
int sumOddPosition = SumArray(arrayOddPosition);
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях, в массиве:");
PrintArray(array);
Console.WriteLine($"-> {sumOddPosition}");
Console.WriteLine("Массив элементов исходного массива, стоящих на нечётных позициях:");
PrintArray(arrayOddPosition);

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

bool IsCorrectSize(int num, int sizeMin)
{
    return (num < sizeMin) ? false : true;
}

// Метод вычисления суммы элементов массива
int SumArray(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
        sum += arr[i];
    return sum;
}

// Метод создания массива из исходного на основе элементов на нечётных позициях
int[] OddPositionArray(int[] arr)
{
    int sizeNew = 0;
    int[] arrNew = new int[sizeNew];
    for (int i = 1; i < arr.Length; i += 2)
    {
        sizeNew++;
        Array.Resize(ref arrNew, sizeNew);
        arrNew[sizeNew - 1] = arr[i];
    }
    return arrNew;
}