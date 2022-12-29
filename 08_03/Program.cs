// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3

// Результирующая матрица будет:
// 18 20
// 15 18



Console.Clear();

const int LeftRange = 0;
const int RightRange = 10;

int linesA = inputNumber("Введите количество строк 1 массива: ");
int columnsA = inputNumber("Введите количество столбцов 1 массива: ");
int linesB = inputNumber("Введите количество строк 2 массива: ");
int columnsB = inputNumber("Введите количество столбцов 2 массива: ");

if (columnsA != linesB) // Количество столбцов первого массива должно быть равно количеству строк второго массива
{
    Console.WriteLine("Такие матрицы умножать нельзя!");
    return;
}

int[,] A = FillArray2D(linesA, columnsA, LeftRange, RightRange);
int[,] B = FillArray2D(linesB, columnsB, LeftRange, RightRange);

PrintArray2D(A);
Console.WriteLine();

PrintArray2D(B);
Console.WriteLine();

PrintArray2D(MultiplicationMatrix(A, B));

int inputNumber(string str) // Проверяем чтобы вводилось число
{
    int number;
    string text;

    while (true)
    {
        Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}

int[,] FillArray2D(int m, int n, int min, int max) // Заполняем массив
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }

    }
    return array;
}

void PrintArray2D(int[,] array) // Выводим массив в консоль
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "   |   ");
        }
        Console.WriteLine();
    }
}

int[,] MultiplicationMatrix(int[,] arrayA, int[,] arrayB) // Умножаем матрицы матриц
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int k = 0; k < arrayA.GetLength(1); k++)
            {
                arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
            }
        }
    }
    return arrayC;
}
