// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Answer(num, 7, 23));

string Answer(int number, int firstDigit, int secondDigit)
{
    return IsKratno(number, firstDigit, secondDigit) ? $"Число {number} кратно одновременно 7 и 23" : $"Число {number} не кратно одновременно 7 и 23";
}

bool IsKratno(int number, int firstDigit, int secondDigit)
{
    return (number % firstDigit == 0) && (number % secondDigit == 0) ? true : false;
}