// Задача 27: Напишите программу, 
// которая принимает на вход число 
// и выдаёт сумму цифр в числе.
//
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// -----------------------------------


int number = EnterNumber("Введите число: ");
int numberSumDigits = SumDigits(number);
PrintAnswer($"Сумма цифр числа {number}:", number, numberSumDigits);

int SumDigits(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum > 0 ? sum : -sum;
}

int EnterNumber(string text) 
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintAnswer(string text, int num, int answer) 
{
    Console.WriteLine(text);
    Console.WriteLine($"{num} -> {answer}");
}
