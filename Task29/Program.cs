
/*
Задача 29: Напишите программу, которая 
задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/


Console.WriteLine("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

int[] array = new int[sizeArray];

RandomNumbers(array);
PrintArray(array);

void RandomNumbers(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 101);   
    }
}


void PrintArray(int[] arr)
{
for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write($"[{arr[i]},");
        if (i > 0 && i < arr.Length - 1) Console.Write($"{arr[i]},");
        if (i == arr.Length - 1) Console.Write($"{arr[i]}" + "]");
    }
}

