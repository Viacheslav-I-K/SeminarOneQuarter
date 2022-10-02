
/*
Задача 32: Напишите программу замена элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

Console.WriteLine("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayRndInt(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-10, 11);
        if (array[i] == 0) array[i] = rnd.Next(-10, 11);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("Изначальный массив: [");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length -1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");

}

void PrintInverseArray(int[]array)
{

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
    Console.Write("Массив после инверсии: [");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length -1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] arr = CreateArrayRndInt(sizeArray);
PrintArray(arr);
PrintInverseArray(arr);


