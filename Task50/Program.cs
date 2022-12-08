// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1,7 -> такого элемента в массиве нет


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // 3
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 4
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("  |");
    }
}

void FindElem(int x, int y, int[,] matrix)
{

    if (x < matrix.GetLength(0) && y < matrix.GetLength(1))
        Console.WriteLine($"На позиции ({x}, {y}) находится элемент {matrix[x, y]}");
    else Console.WriteLine("Такого элемента в массиве нет");
}

Console.Write("Введите позицию элемента (через запятую) для его поиска: ");
int rows, columns;
string[] position = Console.ReadLine().Split(',');
rows = int.Parse(position[0]);
columns = int.Parse(position[1]);

int[,] array2D = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2D);
FindElem(rows, columns, array2D);