// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

const int SIZE = 10;
const int LEFT_RANGE = 100;
const int RIGHT_RANGE = 1000;

int[] Array = FillArray(SIZE, LEFT_RANGE, RIGHT_RANGE);

Print(Array);

Console.WriteLine($"В массиве чётных чисел: {HowManyEvenNumbers()}");

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

// Считаем количество чётных чисел
int HowManyEvenNumbers()
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
        if (Array[i] % 2 == 0)
            count++;
    return count;
}


// Вывод массива в консоль
void Print(int[] array)
{
    Console.WriteLine($"[ {String.Join(" | ", array)} ]");
}
