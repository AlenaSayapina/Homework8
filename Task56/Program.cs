// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
}
void PrintArray(int[,] intArray)
{
    for (int i = 0; i < intArray.GetLength(0); i++)
    {
        for (int j = 0; j < intArray.GetLength(1); j++)
        {
            Console.Write($"{intArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
int minsum = Int32.MaxValue;
int index = 0;


void SumRowsArray(int[,] sumArray)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        if (sum < minsum)
        {
            minsum = sum;
            index = i + 1;
        }
    }
}
SumRowsArray(array);
Console.WriteLine($"Строка с наименьшей суммой элементов: {index} строка");