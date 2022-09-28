
/*
Задача 30: Напишите программу, которая
выводит массив из 8 элементов, заполненный
нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

Console.WriteLine("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

int[] array = new int[sizeArray];

void RandomNumbers(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length - 1; i++)
    {
        arr[i] = rnd.Next(0, 2);   
    }
}

RandomNumbers(array);
PrintArray(array);

void PrintArray(int[] arr)
{
for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write($"[{arr[i]},");
        if (i > 0 && i < arr.Length - 1) Console.Write($"{arr[i]},");
        if (i == arr.Length - 1) Console.Write($"{arr[i]}" + "]");
    }
}

