// Задача 68: Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int numberM = EnterNumber("Введите первое неотрицательное число: ");

if (!IsCorrectInput(numberM))
{
    Console.WriteLine("Введённое число не является неотрицательным!");
    return;
}

int numberN = EnterNumber("Введите второе неотрицательное число: ");

if (!IsCorrectInput(numberN))
{
    Console.WriteLine("Введённое число не является неотрицательным!");
    return;
}

int valueAkkermanFunc = GetAkkermanFunction(numberM, numberN); 

Console.WriteLine($"Функция Аккермана от чисел {numberM} и {numberN}:");
Console.WriteLine($"m = {numberM}, n = {numberN} - > A(m,n) = {valueAkkermanFunc}");

int EnterNumber(string text) 
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

bool IsCorrectInput(int num)
{
    return (num < 0) ? false : true;
}

int GetAkkermanFunction(int numM, int numN)
{
    if (numM == 0) return numN + 1;
    if (numN == 0) return GetAkkermanFunction(numM - 1, 1);
    return GetAkkermanFunction(numM - 1, GetAkkermanFunction(numM, numN - 1));
}