// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] FillMatrix(int row, int col)
{
    double[,] matrix = new double[row, col];
    Random random = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            //matrix[i,j] = Math.Round(random.NextDouble() * 10, 1); Так получается только от 0 диапазон указать до чего-то.
            matrix[i,j] = Math.Round(random.Next(-100, 101)*0.1, 1); 
            //Такой вариант нашел в интернете, не разобрался как можно было бы задать диапазон через NextDouble т.к. метод не принимает аргументов.
        }
    }
    return matrix;
}

int ReadInt(string messege)
{
    System.Console.Write(messege);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i,j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int row = ReadInt("Введите количество столбцов: ");
int col = ReadInt("Введите количество колонок: ");

double[,] matrix = FillMatrix(row, col);
PrintMatrix(matrix);