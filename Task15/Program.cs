// Задача 15: Напишите программу, 
// которая принимает на вход цифру, 
// обозначающую день недели, 
// и проверяет, является ли этот день выходным.
//
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите день недели: ");
string weekday = Console.ReadLine();

Console.WriteLine(Holiday(weekday));

string Holiday(string day)
{
    switch (day)
    {
        case "1":
            return $"{day} -> Понедельник не является выходным днём";
            break;
        case "2":
            return $"{day} -> Вторник не является выходным днём";
            break;
        case "3":
            return $"{day} -> Среда не является выходным днём";
            break;
        case "4":
            return $"{day} -> Четверг не является выходным днём";
            break;
        case "5":
            return $"{day} -> Пятница не является выходным днём";
            break;
        case "6":
            return $"{day} -> Суббота является выходным днём";
            break;
        case "7":
            return $"{day} -> Воскресенье является выходным днём";
            break;
        default:
            return $"{day} -> Таких дней недели нет";
            break;
    }
}
