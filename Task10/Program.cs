// Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа. 
//  Выполнить с помощью числовых операций 
//  (целочисленное деление, остаток от деления).
//
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num < 1000)
{
    int secondDigit = (num / 10) % 10;
    Console.WriteLine("Вторая цифра введённого числа:");
    Console.WriteLine($"{num} -> {secondDigit}");
}
else
{
    Console.WriteLine("Введённое число не является трёхзначным");
}