// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76



Console.Clear();

const int SIZE = 5;
const int LEFT_RANGE = -99;
const int RIGHT_RANGE = 100;

double[] Array = FillArray(SIZE, LEFT_RANGE, RIGHT_RANGE);

Print(Array);

Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {Math.Round(DifferenceMaximumMinimumArrayElements(), 2)}");

// Заполняем массив
double[] FillArray(int SIZE, int LEFT_RANGE, int RIGHT_RANGE)
{
    double[] array = new double[SIZE];
    for (int i = 0; i < SIZE; i++)
    {
        array[i] = Math.Round((new Random().Next(LEFT_RANGE, RIGHT_RANGE) + new Random().NextDouble()), 2);
    }
    return array;
}

// Считаем разницу между максимальным и минимальным элементом массива
double DifferenceMaximumMinimumArrayElements()
{
    double min = 0;
    double max = 0;
    for (int i = 0; i < Array.Length; i++)
    {

        if (Array[i] > max)
        {
            max = Array[i];
        }
        else if (Array[i] < min)
        {
            min = Array[i];
        }
    }
    double diff = max - min;
    return diff;
}

// Вывод массива в консоль
void Print(double[] array)
{
    Console.WriteLine($"[ {String.Join(" | ", array)} ]");
}
