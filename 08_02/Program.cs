// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



Console.Clear();

int m = inputNumber("Введите размер массива m: ");
//int n = inputNumber("Введите количество столбцов массива n: ");
int n = m;

const int LeftRange = -9;
const int RightRange = 9;

double[,] array = FillArray2D(m, n);
PrintArray2D(array);
MinimumSumLineElements(array);

void MinimumSumLineElements(double[,] array)
{
    Console.WriteLine();
    double minLine = 0;
    double minSumLine = 0;
    double sumLine = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minLine += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumLine += array[i, j];
        if (sumLine < minLine)
        {
            minLine = sumLine;
            minSumLine = i;
        }
        sumLine = 0;
    }
    Console.Write($"{minSumLine + 1} строка, сумма элементов строки = {Math.Round(minLine, 2)}");
}

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

double[,] FillArray2D(int m, int n) //  Заполняем двумерный массив
{
    double[,] array = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(new Random().Next(LeftRange, RightRange) + new Random().NextDouble(), 2);
        }
    }
    return array;
}

void PrintArray2D(double[,] array) // Выводим двумерный массив в консоль
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
