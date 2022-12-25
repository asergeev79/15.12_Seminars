// Задача 13: Напишите программу, 
// которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. 
// Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).
//
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (!IsThreeDigit(num))
{
    Console.WriteLine($"{num} -> третьей цифры нет");
}
else
{
    int thirdDigit = FindThirdDigit(num);
    thirdDigit = (thirdDigit > 0 ? thirdDigit : thirdDigit * (-1));
    Console.WriteLine("Третья цифра ведённого числа:");
    Console.WriteLine($"{num} -> {thirdDigit}");
}

bool IsThreeDigit(int number)
{
    return (number > -100 && number < 100) ? false : true;
}

int FindThirdDigit(int number)
{
    int thirdDigit = 0;
    while (IsThreeDigit(number))
    {
        thirdDigit = number % 10;
        number /= 10;
    }
    return thirdDigit;
}