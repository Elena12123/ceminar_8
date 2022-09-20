Console.WriteLine("введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());


int[,] matrix = new int[m, n];
int[,] matrix2 = new int[m, n];
int[,] result = new int[m,n];
FillArray(matrix);
Console.WriteLine();
Console.WriteLine("Матрица 1");
PrintArray(matrix);
FillArray(matrix2);
Console.WriteLine();
Console.WriteLine("Матрица 2");
PrintArray(matrix2);


if (matrix.GetLength(0) != matrix2.GetLength(1))
{
    Console.WriteLine("Операция не возможна! ");
    
}
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        result[i, j] = 0;
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            result[i, j] += matrix[i, k] * matrix2[k, j];
        }
    }

}



Console.WriteLine("Результат ");
PrintArray(result);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }

        Console.WriteLine("");
    }
}
