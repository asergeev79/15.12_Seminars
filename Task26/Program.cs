// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int number = EnterNumber("Введите число: ");
int count = CountDigits(number); 
PrintAnswer($"Количество цифр в числе {number}:", number, count);

int CountDigits(int num)
{
    int count = 0;
    // while (num != 0)
    // {
    //     num /= 10;
    //     count++;
    // }
    for (int i = num; i != 0; i /= 10) count++;
    return count;
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
