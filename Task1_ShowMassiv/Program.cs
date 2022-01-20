// Двумерный, целыми числами

int[,] CreateArray(int row, int column)
{
    int[,] matrix = new int[row, column];
    FillArray(matrix);
    return matrix;
}

void FillArray (int[,] matrix)
{
    var rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(100);
        }
    }
}
void PrintMatrix (int[,]matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write ($"{matrix[i,j],4}");
        }
        Console.WriteLine();
    }
}

Console.Write("Задайте число строк массива: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Задайте число столцов массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int [,] Matrix = CreateArray(m,n);
PrintMatrix (Matrix);
