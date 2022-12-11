// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



int a = InputNumber();

int b = InputNumber();

Console.WriteLine($"Число {a} в степени {b} = {PowNumber()}");

// Возведение в степень
int PowNumber()
{
    int result = a;

    for (int i = 1; i < b; i++)
    {
        result = result * a;
    }
    return result;
}

// Проверяем число или нет
int InputNumber()
{
    int number;
    string text;

    while (true)
    {
        Console.Write("Введите число: ");
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        Console.WriteLine("Введено не число, попробуйте еще раз.");
    }
    return number;
}
