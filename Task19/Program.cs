// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
//
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Answer(num));

string Answer(int number)
{
    if (number >= 10000 && number < 100000)
    {
        if (IsPalindrom(number)) return $"Число {number} является палиндромом";
        else return $"Число {number} не является палиндромом";
    }
    else return "Введённое число не является пятизначным";
}

bool IsPalindrom(int number)
{
    int firstDigit = number / 10000;
    int fifthDigit = number % 10;
    if (firstDigit != fifthDigit) return false; 
    else
    {
        int secondDigit = (number / 1000) % 10;
        int fourthDigit = (number / 10) % 10;
        return secondDigit != fourthDigit ? false : true; 
    }
}
