// 49.Показать двумерный массив размером m×n заполненный вещественными числами

double[,] CreateArray(int row, int column)
{
    double[,] matrix = new double[row, column];
    FillArray(matrix);
    return matrix;
}

void FillArray (double[,] matrix)
{
    var rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.NextDouble() * 100;
        }
    }
}
void PrintMatrix (double[,]matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write ($"{matrix[i,j],8:N3}");
        }
        Console.WriteLine();
    }
}

Console.Write("Задайте число строк массива: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Задайте число столцов массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Double [,] Matrix = CreateArray(m,n);
PrintMatrix (Matrix);


