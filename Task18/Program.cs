
/*
Задача 18: Напишите программу, которая по
заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y).
*/

Console.Write("Введите номер четверти: ");
string quarter = (Console.ReadLine());

string RangeQuarter(string quar)
{
    if (quar == "1") return "Диапазон возможных координат точек: X (> 0), Y (> 0)";
    if (quar == "2") return "Диапазон возможных координат точек: X (< 0), Y (> 0)";
    if (quar == "3") return "Диапазон возможных координат точек: X (< 0), Y (< 0)";
    if (quar == "4") return "Диапазон возможных координат точек: X (> 0), Y (< 0)";
    return "Введены некорректные данные";
}

string rangeQuarter = RangeQuarter(quarter);

Console.WriteLine(rangeQuarter);

