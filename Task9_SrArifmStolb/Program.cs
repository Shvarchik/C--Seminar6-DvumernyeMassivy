// Среднее арифметическое каждого из столбцов

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
void PrintMatrix (int[,]matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write ($"{matrix[i,j],5}");
        }
        Console.WriteLine();
    }
}
void PrintArray (double [] array)
{
    for (int i=0;i<array.Length;i++)
        Console.Write ($"{array[i],5:N2}");
}
var rand = new Random();
int row = rand.Next(1,10);
int column = rand.Next(1,10);
Console.WriteLine ($"{row}, {column}");
int [,] Matrix = CreateArray(row,column);
Console.WriteLine("Исходный массив:");
PrintMatrix (Matrix);
Console.WriteLine();
double sum = 0;
double[] Summ = new double [column];
for (int j=0;j<Matrix.GetLength(1);j++)
    {
        for (int i=0;i<Matrix.GetLength(0); i++)
        {
            sum = sum + Matrix [i,j];
        }
        Summ[j] = sum/row;
        sum = 0;
    }
PrintArray(Summ);
