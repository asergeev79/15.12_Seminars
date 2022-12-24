// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Write("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Answer(num1, num2));

string Answer(int a, int b)
{
    if (IsSquare(a, b))
    {
        return $"Число {b} является квадратом числа {a}";
    }
    else if (IsSquare(b, a))
    {
        return $"Число {a} является квадратом числа {b}";
    }
    else
    {
        return "Ни одно из чисел не является квадратом другого";
    }
}

bool IsSquare(int a, int b)
{
    return (a * a == b) ? true : false;
}