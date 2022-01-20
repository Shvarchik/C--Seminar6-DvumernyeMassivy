// 51. Задать двумерный массив следующим правилом: Aₘₙ = m+n
void FillArray (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i+j+2;
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
int [,] Matrix = new int [m,n];
FillArray (Matrix);
PrintMatrix (Matrix);
