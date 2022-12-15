// Задача 8: Напишите программу, 
// которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
//
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите натуральное число: ");
int N = Convert.ToInt32(Console.ReadLine());

int i = 2;
if (i > N)
{
    Console.WriteLine($"Натуральных четных чисел, меньших {N}, нет");
}
else
{
    while (i <= N)
    {
        Console.Write($"{i} ");
        i += 2;
    }
    Console.WriteLine();
}
