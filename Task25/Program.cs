// Задача 25: Напишите цикл, 
// который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
//
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// -----------------------------------------------------------------------------

// Ввод значений в консоли
int numberA = EnterNumber("Введите возводимое число A: ");
int numberB = EnterNumber("Введите степень B: ");

// Вычисление степени числа (как положительной, так и отрицательной)
double powerAB = Power(numberA, numberB);

// Вывод результата
PrintAnswer($"Число {numberA} в степени {numberB}:", numberA, numberB, powerAB);

// Метод вычисления степени числа
double Power(int num1, int num2)
{
    int stepen = (num2 > 0) ? num2 : -num2;
    double result = 1;
    for (int i = 0; i < stepen; i++) result *= num1;
    return (num2 > 0) ? result : (1 / result);
}

// Метод ввода численного целого значения
int EnterNumber(string text) 
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

// Метод вывода форматированного ответа
void PrintAnswer(string text, int num1, int num2, double answer)  
{
    Console.WriteLine(text);
    Console.WriteLine($"{num1}, {num2} -> {answer}");
}
