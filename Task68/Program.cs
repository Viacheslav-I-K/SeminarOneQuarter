
/*
Задача 68: Напишите программу вычисления функции 
Аккермана с помощью рекурсии. Даны два 
неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.Write("Введите число m для функции Аккермана А(m, n): ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число n для функции Аккермана А(m, n): ");
int numberN = Convert.ToInt32(Console.ReadLine());

int Ackerman(int numM, int numN)
{
    if (numM == 0) return numN + 1;

    return numM > 0 && numN == 0 ? Ackerman(numM - 1, 1) : Ackerman(numM - 1, Ackerman(numM, numN - 1));
}

int asckerman = Ackerman(numberM, numberN);
Console.WriteLine(asckerman);




