
/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int sumNumber = SumNaturalsNumbers(numberM, numberN);
Console.Write($"Сумма чисел от {numberM} до {numberN} = " + sumNumber);

int SumNaturalsNumbers(int numM, int numN)
{
    int sumNum = numM;
    if (numM == numN) return numM;
    return numM > numN ? sumNum += SumNaturalsNumbers(numM - 1, numN) : sumNum += SumNaturalsNumbers(numM + 1, numN);
}



