// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



int arrayLenght = inputNumber(); // Чтобы программа сама задавала размер массива 8 строку нужно написать так int arrayLenght = 8; и метод проверки числа тоже станет не нужен (со строки 26, до конца программы)

int[] array = Auto(arrayLenght);

Console.Write(string.Join(" | ", array));

//Задаём массив
int[] Auto(int length)
{
    int[] arrray = new int[length];
    Random rand = new Random();
    for (int i = 0; i < arrray.Length; i++)
    {
        arrray[i] = rand.Next(0, 100);
    }
    return arrray;
}

// Проверяем число или нет
int inputNumber()
{
    int number;
    string text;

    while (true)
    {
        Console.Write("Введите размер массива: ");
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        Console.WriteLine("Введено не число, попробуйте еще раз.");
    }
    return number;
}
