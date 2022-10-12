
/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)
*/



int sizeRows = 2;
int sizeColumns = 2;
int sizeDepth = 2;

int minNumber = 1;
int maxNumber = 7;


int[, ,] matrix3D = CreaterMatrixRndInt(sizeRows, sizeColumns, sizeDepth, minNumber, maxNumber);
PrintMatrix(matrix3D);

Console.WriteLine();



int[, ,] CreaterMatrixRndInt(int rows, int columns, int depth, int min, int max)
{
    Random rnd = new Random();
    int[, ,] matrix = new int[rows, columns, depth];
    int firstNum = rnd.Next(min, max + 1);

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = firstNum + rnd.Next(min, max + 1);
                firstNum = matrix[i, j, k];
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[, ,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k}); ");
            }
        }
    }
}









