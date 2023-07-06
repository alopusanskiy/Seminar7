// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] matrix = new int[row, col];
    Random random = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(leftRange, rightRange);
        }
    }
    return matrix;
}

int ReadInt(string messege)
{
    System.Console.Write(messege);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void FindNumber(int[,] array, int row, int col)
{
    if (row >= array.GetLength(0) || col >= array.GetLength(1))
        System.Console.WriteLine($"Индекса {row} {col} в этом массиве нет!");
    else
        System.Console.WriteLine($"Под индексом {row},{col} находится число{array[row, col]}");
}

int row = ReadInt("Введите количество столбцов: ");
int col = ReadInt("Введите количество колонок: ");

int findRow = ReadInt("Введите столбец в котором искать число:");
int findCol = ReadInt("Введите колонку в которой искать число:");

int[,] matrix = FillMatrix(row, col, -100, 100);
PrintMatrix(matrix);
FindNumber(matrix, findRow, findCol);