
/*
Задача 69: Напишите программу, которая на вход принимает два числа
 A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int sqrNumber = SqrNumbers(numberA, numberB);
Console.WriteLine(sqrNumber);



int SqrNumbers(int numA, int numB)
{
    int sqrNum = numA;
    if (numB == 0) return 1;
    return sqrNum *= SqrNumbers(numA, numB - 1);
    //return numB == 0 ? 1 : numA * SqrNumbers(numA, numB - 1); // Тернальный способ
}





