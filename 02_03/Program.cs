// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет



Console.Write("Введите номер дня недели  ");

int num = Convert.ToInt32(Console.ReadLine());

while (true)
{
    if (num >= 1 && num <= 5)
    {
        Console.Write("Это не выходной");
    }

    else if (num >= 6 && num <= 7)
    {
        Console.Write("Это выходной");
    }
    else Console.Write("Не существует такого дня недели");
    break;
}
