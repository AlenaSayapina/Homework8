// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

Console.WriteLine("Введите размер 2х матриц: ");
int size = int.Parse(Console.ReadLine());
int[,] arrayA = new int[size, size];
int[,] arrayB = new int[size, size];
int[,] arrayC = new int[size, size];
GetArray(arrayA);
GetArray(arrayB);
PrintArray(arrayA);
Console.WriteLine();
PrintArray(arrayB);

void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
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

void MultipMassiv(int[,] array)
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            for (int m = 0; m < size; m++)
            {
                arrayC[i,j] = arrayA[i,j] * arrayB[i,j];
            }
        }
    }
}

Console.WriteLine();
Console.WriteLine("Произведение 2х матриц");
MultipMassiv(arrayC);
PrintArray(arrayC);



