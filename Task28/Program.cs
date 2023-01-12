// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int number = EnterNumber("Введите число: ");
int multiply = MultNumber(number);
PrintAnswer($"Произведение чисел от 1 до {number}:", number, multiply);

int MultNumber(int num) 
{
    int mult = 1;
    for (int i = 1; i <= num; i++) mult *= i;
    return mult;
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