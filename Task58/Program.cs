
/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/


Console.Write("Введите количество строк для матрицы №1: ");
int sizeRows1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов для матрицы №1: ");
int sizeColumns1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк для матрицы №2: ");
int sizeRows2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов для матрицы №2: ");
int sizeColumns2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное число элемента массивов: ");
int minNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное число элемента массивов: ");
int maxNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();


int[,] matrixOne = CreaterMatrixRndInt(sizeRows1, sizeColumns1, minNumber, maxNumber);
Console.WriteLine("Матрица №1:");
PrintMatrix(matrixOne);
Console.WriteLine();

int[,] matrixTwo = CreaterMatrixRndInt(sizeRows2, sizeColumns2, minNumber, maxNumber);
Console.WriteLine("Матрица №2:");
PrintMatrix(matrixTwo);
Console.WriteLine();

if(matrixOne.GetLength(1) == matrixTwo.GetLength(0))
{
int[,] multiplicationMatrix = MultiplicationMatrix(matrixOne, matrixTwo);
Console.WriteLine("Произведение матрицы №1 на матрицу №2:");
PrintMatrix(multiplicationMatrix);
}
else Console.Write("Введены не корректные матрицы.");


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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} | ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

int[,] MultiplicationMatrix(int[,] matrixOne, int[,] matrixTwo)
{

    int[,] multiMatrix = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];
    for(int i = 0; i < multiMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < multiMatrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrixOne.GetLength(1); k++)
            {
                multiMatrix[i, j] += matrixOne[i, k] * matrixTwo[k, j];
            }
            
        }

    }
    return multiMatrix;
}








