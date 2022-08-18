// Задача 62. Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int n = 4;
int[,] nums = new int[n, n];

int num = 1;
int i = 0;
int j = 0;

void SpiralArrey(int[,] array)
{
    while (num <= nums.GetLength(0) * nums.GetLength(1))
    {
        nums[i, j] = num;
        if (i <= j + 1 && i + j < nums.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= nums.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > nums.GetLength(1) - 1)
            j--;
        else
            i--;
        num++;
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

SpiralArrey(nums);
PrintArray(nums);

