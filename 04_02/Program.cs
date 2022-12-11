// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12



int a = InputNumber();

Console.Write("Сумма всех цифр в числе равна: " + SumNumber());

//Сумма чисел
int SumNumber()

{
    int sum = 0;
    int i = a;
    while (i > 0)
    {
        int num = i % 10;
        i = i / 10;
        sum = sum + num;
    }
    return sum;
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
