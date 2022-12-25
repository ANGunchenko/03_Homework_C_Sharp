// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



Console.Clear();

int m = inputNumber("Введите количество строк массива m: ");
int n = inputNumber("Введите количество столбцов массива n: ");

const int LeftRange = 0;
const int RightRange = 10;

int[,] array = FillArray2D(m, n);
PrintArray2D();
ArithmeticMeanColumnElements();

void ArithmeticMeanColumnElements() // Вычисляем среднее арифметическое в каждом столбце и выводим в консоль
{for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    Console.WriteLine($"Среднее арифметическое {j + 1} столбца = {Math.Round((sum / array.GetLength(0)), 2)}");
}
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
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(LeftRange, RightRange);
        }
    }
    return array;
}

void PrintArray2D() // Выводим двумерный массив в консоль
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "   |   ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
