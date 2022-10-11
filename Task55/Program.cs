
/*
Задача 55: Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя.
*/



Console.Write("Введите количество строк в 2D массиве: ");
int sizeRows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в 2D массиве: ");
int sizeColumns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное число элемента массива: ");
int minNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное число элемента массива: ");
int maxNumber = Convert.ToInt32(Console.ReadLine());

int[,] matrix2D = CreaterMatrixRndInt(sizeRows, sizeColumns, minNumber, maxNumber);
PrintMatrix(matrix2D);

Console.WriteLine();

int[,] TranspMatrix = TranspArray(matrix2D);
PrintMatrix(TranspMatrix);





int[,] CreaterMatrixRndInt(int rows, int columns, int min, int max)
{
    Random rnd = new Random();
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4} | ");
            else Console.Write($"{matrix[i, j], 4} ");
        }
        Console.WriteLine("|");
    }
}


int[,] TranspArray(int[,] matrix)
{
    int[,] result = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++) // 0 - rows  0 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 1 - columns
        {
            result [j,i] = matrix[i,j];
        }
    }
    return result;
    
}

// второй метод
// void TransponArray2(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = i ; j < matrix.GetLength(1); j++)
//         {
//             int num = matrix[j, i];
//             matrix[j, i] = matrix[i, j];
//             matrix[i, j] = num;
//         }
//     }
// }
