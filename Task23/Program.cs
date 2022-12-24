// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
//
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.Write("Введите натуральное число N: ");
int num = Convert.ToInt32(Console.ReadLine());

Answer(num);

void Answer(int number)
{
    if (IsNatural(number))
    {
        Console.WriteLine($"Таблица кубов чисел от 1 до {number}:");
        Console.WriteLine($"{number} ->");
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine($"{i} | {Cube(i)}");
        }
    }
    else
    {
        Console.WriteLine("Введённое число не является натуральным");
    }
}

bool IsNatural(int number)
{
    return number > 0 ? true : false;
}

int Cube(int number)
{
    return number * number * number;
}