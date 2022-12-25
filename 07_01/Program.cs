// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9



Console.Clear();

int m = inputNumber("Введите количество строк массива m: ");
int n = inputNumber("Введите количество столбцов массива n: ");

const int LeftRange = -9;
const int RightRange = 10;

PrintArray2D(FillArray2D());

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

double[,] FillArray2D() //  Заполняем двумерный массив
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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "   |   ");
        }
        Console.WriteLine();
    }
}
