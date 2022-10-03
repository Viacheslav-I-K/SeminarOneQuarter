
/*
Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

Console.Write("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное число в массиве: ");
int numberMin = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное число в массиве: ");
int numberMax = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArrayRndInt(sizeArray, numberMin, numberMax);
Console.Write("Рандомно созданный массив: ");
PrintArray(arr);
int[] arrNew = CompositionPairNumbers(arr);
Console.Write("Преобразованый массив: ");
PrintArray(arrNew);


int[] CreateArrayRndInt(int size, int numMin, int numMax)
{
    Random rnd = new Random();
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(numMin, numMax + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}]");
    }
}

int[] CompositionPairNumbers(int[] array)
{
    int size = default;

    if (array.Length % 2 == 0) size = array.Length / 2;
    else size = array.Length / 2 + 1;

    int[] arrayNew = new int[size];
    int count = array.Length - 1;
    for (int i = 0; i <= count; i++)
    {
            arrayNew[i] = array[i] * array[count];
            count--;
    }
    if (array.Length % 2 != 0) arrayNew[size - 1] = array[size - 1];
    return arrayNew;
}

