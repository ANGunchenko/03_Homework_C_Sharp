// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет



Console.Clear();

int m = inputNumber("Введите количество строк массива m: ");
int n = inputNumber("Введите количество столбцов массива n: ");

int line = inputNumber("Введите индекс из строки: ");
int column = inputNumber("Введите индекс из столбца: ");

const int LeftRange = 0;
const int RightRange = 10;

int[,] array = FillArray2D(m, n);
PrintArray2D(array);
Console.WriteLine();
SearchingForAnItemByIndexes();


void SearchingForAnItemByIndexes() // Ищем и выводим в консоль элемент по индексам массива
{
    if (line < array.GetLength(0) && column < array.GetLength(1))

        Console.WriteLine($"| {array[line, column]} | - это элемент массива с индексами | {line} | {column} |");

    else Console.WriteLine($"| {line} | {column} | - элемента с такими индексами нет в массиве");
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

int[,] FillArray2D(int m, int n) //  Заполняем двумерный массив
{
    Random rand = new Random();
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(LeftRange, RightRange);
        }
    }
    return array;
}

void PrintArray2D(int[,] array) // Выводим двумерный массив в консоль
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "   |   ");
        }
        Console.WriteLine();
    }
}
