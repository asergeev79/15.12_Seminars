// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите день недели: ");
int weekday = Convert.ToInt32(Console.ReadLine());

switch (weekday)
{
    case 1:
        Console.WriteLine($"{weekday} -> Понедельник");
        break;
    case 2:
        Console.WriteLine($"{weekday} -> Вторник");
        break;
    case 3:
        Console.WriteLine($"{weekday} -> Среда");
        break;
    case 4:
        Console.WriteLine($"{weekday} -> Четверг");
        break;
    case 5:
        Console.WriteLine($"{weekday} -> Пятница");
        break;
    case 6:
        Console.WriteLine($"{weekday} -> Суббота");
        break;
    case 7:
        Console.WriteLine($"{weekday} -> Воскресенье");
        break;
    default:
        Console.WriteLine($"{weekday} -> Таких дней недели нет");
        break;
}