// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



Console.Clear();

const int SIZE = 4;
const int LEFT_RANGE = -99;
const int RIGHT_RANGE = 100;

int[] Array = FillArray(SIZE, LEFT_RANGE, RIGHT_RANGE);

Print(Array);

Console.WriteLine($"Сумма чисел на нечётных позициях: {SumNumbersOddPositions()}");

// Заполняем массив
int[] FillArray(int SIZE, int LEFT_RANGE, int RIGHT_RANGE)
{
    int[] array = new int[SIZE];
    for (int i = 0; i < SIZE; i++)
    {
        array[i] = new Random().Next(LEFT_RANGE, RIGHT_RANGE);
    }
    return array;
}

// Считаем сумму чисел на нечётных позициях
int SumNumbersOddPositions()
{
    int sum = 0;
    for (int i = 1; i <= Array.Length; i += 2)
        sum = sum + Array[i];
    return sum;
}

// Вывод массива в консоль
void Print(int[] array)
{
    Console.WriteLine($"[ {String.Join(" | ", array)} ]");
}
