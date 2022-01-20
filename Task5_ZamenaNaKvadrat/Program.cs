// 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

int[,] CreateArray (int m,int n)
{
    int[,] matrix = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i,j] = new Random().Next(1,11);
        }
    }
    return matrix;
}

int[,] NewArray (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i=i+2)
    {
        for (int j = 0; j < matrix.GetLength(1); j=j+2)
        {
            matrix[i, j] = matrix[i, j]*matrix[i, j];
        }
    }
    return matrix;
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

var rand = new Random();
int row = rand.Next(1,10);
int column = rand.Next(1,10);
Console.WriteLine ($"{row}, {column}");
int [,] Matrix = CreateArray(row,column);
Console.WriteLine("Исходный массив:");
PrintMatrix (Matrix);
Console.WriteLine("Новый массив:");
int [,] Matrix1 = NewArray (Matrix);
PrintMatrix (Matrix1);
