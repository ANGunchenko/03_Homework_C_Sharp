// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3



Console.Clear();

int size = InputNumber("Введите количество чисел: ");

int num = DefinePositiveNumbers();

Console.WriteLine($"Положительных чисел: {num}");


// Вводим числа и считаем количество чисел больше нуля
int DefinePositiveNumbers()
{
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        int a = InputNumber($"Введите число {i + 1}: ");
        if (a > 0)
            count++;
    }
    return count;
}

// Проверяем чтобы вводились только числа
int InputNumber(string str)
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
