﻿// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

string answer = (num1 % num2 == 0) 
            ? $"Число {num1} кратно числу {num2}" 
            : $"Число {num1} не кратно числу {num2}, остаток {num1 % num2}";
Console.WriteLine(answer);
