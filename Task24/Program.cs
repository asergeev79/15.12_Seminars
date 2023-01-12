// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int number = EnterNumber("Введите число: ");
int sum = SumNumber(number);
PrintAnswer($"Сумма чисел от 1 до {number}:", number, sum);

int SumNumber(int num) 
{
    int sum = 0;
    for (int i = 1; i <= num; i++) sum += i;
    return sum;
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