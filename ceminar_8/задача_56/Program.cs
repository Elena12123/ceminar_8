Console.WriteLine("введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[m, n];
FillArray(numbers);
Console.WriteLine();
Console.WriteLine("Массив до изменения");
PrintArray(numbers);


{
    int minsum = Int32.MaxValue;
    int line = 0;

    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            sum = sum + numbers[i, j];
        }
        if (sum < minsum)
        {
            minsum = sum;
            line++;
        }
    }
    Console.WriteLine("строка с наименьшей суммой елементов под номером: " + (line) + ", с суммой елементов равной: " + (minsum));
}




void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 20);
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
