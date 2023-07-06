// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

float[] ArithMean(int[,] arr, float[] arrayResult, int row) // Находим среднее арифметическое.
{
    int index = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            arrayResult[index] += arr[j, i];
        }
        arrayResult[index] = arrayResult[index] / row;
        index++;
    }
    return arrayResult;
}
void PrintArithMean(float[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(Math.Round(array[i], 1) + ", ");
        // Вывод написал отдельным методом т.к. выводя через string.Join не мог изменить кол-во символов после запятой
    }
}

int row = ReadInt("Введите количество столбцов: ");
int col = ReadInt("Введите количество колонок: ");

int[,] matrix = FillMatrix(row, col, 0, 10);
float[] arrayArithMean = new float[col];
PrintMatrix(matrix);
ArithMean(matrix, arrayArithMean, row);
PrintArithMean(arrayArithMean);
