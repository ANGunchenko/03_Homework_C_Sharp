// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



Console.Clear();

int n = inputNumber("Введите число: ");
int m = 1;

Console.WriteLine(printNaturalNumber(n, m));

int printNaturalNumber(int n, int m) // Выводим в консоль от n до 1
{
    if (n == m)
        return n;
    else
        Console.Write($"{printNaturalNumber(n, m + 1)}, ");
    return m;
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
