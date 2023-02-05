// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
//
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int number = EnterNumber("Введите натуральное число: ");

if (!IsCorrectInput(number))
{
    Console.WriteLine("Введённое число не является натуральным!");
    return;
}

string naturalSequence = GetNaturalSequence(number);
Console.WriteLine($"Все натуральные числа в промежутке от {number} до 1:");
Console.WriteLine($"N = {number} - > \"" + naturalSequence + "\"");


int EnterNumber(string text) 
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

bool IsCorrectInput(int num)
{
    return (num < 1) ? false : true;
}

string GetNaturalSequence(int num)
{
    if (num == 1) return $"{num}";
    return $"{num}, " + GetNaturalSequence(num - 1);
}