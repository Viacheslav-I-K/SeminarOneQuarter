
/*
Задача 35: Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

Console.Write("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение чисел в массиве: ");
int numberArrayMin = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение чисел в массиве: ");
int numberArrayMax = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение диапазона искомых чисел в массиве: ");
int numberMin = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение диапазона искомых чисел в массиве: ");
int numberMax = Convert.ToInt32(Console.ReadLine());

int[] arr = CreataArrayRndInt(sizeArray, numberArrayMin, numberArrayMax);
PrintArray(arr);
int counter = SearchArrayElem(arr, numberMin, numberMax);

int[] CreataArrayRndInt(int size, int arrayMin, int arrayMax)
{
    Random rnd = new Random();
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(arrayMin, arrayMax);
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

int SearchArrayElem(int[] array, int numMin, int numMax)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= numMin && array[i] <= numMax) count ++;
    }

    return count;
}

if (counter == 0) Console.Write($"Не найдены элементы массива, значение которых лежат в диапазоне от {numberMin} до {numberMax}.");
else Console.Write($"Найдено {counter} элементов массива, значение которых лежат в диапазоне от {numberMin} до {numberMax}.");


