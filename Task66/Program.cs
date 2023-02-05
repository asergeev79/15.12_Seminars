// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N. Выполнить с помощью рекурсии.
//
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int numberM = EnterNumber("Введите первую границу диапазона натуральных чисел: ");

if (!IsCorrectInput(numberM))
{
    Console.WriteLine("Введённое число не является натуральным!");
    return;
}

int numberN = EnterNumber("Введите вторую границу диапазона натуральных чисел: ");

if (!IsCorrectInput(numberN))
{
    Console.WriteLine("Введённое число не является натуральным!");
    return;
}

int sumNaturalSequence = (numberM < numberN) 
    ? GetSumNaturalSequence(numberM, numberN) 
    : GetSumNaturalSequence(numberN, numberM);

Console.WriteLine($"Сумма натуральных чисел в промежутке от {numberM} до {numberN}:");
Console.WriteLine($"M = {numberM}; N = {numberN} - > {sumNaturalSequence}");


int EnterNumber(string text) 
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

bool IsCorrectInput(int num)
{
    return (num < 1) ? false : true;
}

int GetSumNaturalSequence(int numM, int numN)
{
    if (numM == numN) return numN;
    return numN += GetSumNaturalSequence(numM, numN - 1);
}