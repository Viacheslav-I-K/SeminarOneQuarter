
/*
Задача 33: Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да
*/

Console.WriteLine("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите искомое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayRndInt(int size)
{
    Random rnd = new Random();
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 11);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}] ");
    }
    
}

void SearchNumber(int[] array, int num)
{
    int coincidence = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) coincidence += 1;
    }

    if (coincidence > 0) Console.WriteLine($"Заданное число {num} присутствует в массиве.");
    else Console.WriteLine($"Заданное число {num} отсутствует в массиве.");
}

int[] arr = CreateArrayRndInt(sizeArray);
PrintArray(arr);
SearchNumber(arr, number);



