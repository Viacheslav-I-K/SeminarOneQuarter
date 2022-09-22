
// Задача 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int result = -1;


int Multiplicity (int num1, int num2)
{
    int num0 = num1 % num2;
    
    if (num0 == 0) return result = 0;
    return result = num0;   
}

int multiplicity = Multiplicity(number1, number2);
if (multiplicity == 0) Console.WriteLine($"Первое число {number1} является кратным второму числу {number2}.");
else
{
Console.WriteLine($"Первое число {number1} неявляется кратным второму числу {number2}. Остаток jn деления = {result}.");
}
