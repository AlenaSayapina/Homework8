// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

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
DesArray(array);

void DesArray(int[,] arraySt)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int z = 0; z < array.GetLength(1) - 1; z++)
            {
                if (array[i, z] > array[i, z + 1])
                {
                    int tmp = 0;
                    tmp = array[i, z];
                    array[i, z] = array[i, z + 1];
                    array[i, z + 1] = tmp;
                }

            }
        }
    }
}

Console.WriteLine();
PrintArray(array);