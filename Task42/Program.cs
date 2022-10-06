
/*
Задача 42: Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/


Console.Write("Введите положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите систему в которую нужно перевести число: ");
int binary = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayInt(int size, int numMin, int numMax)
{
    Random rnd = new Random();
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(numMin, numMax + 1);
    }
    return array;
}


void ConvertToBin2(int num)
{
    string bin = default;

     if (num > 0)
     {
        bin += num % 2;         
        ConvertToBin2(num / 2);    
     }   

    Console.Write(bin);
}






