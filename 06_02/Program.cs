// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



Console.Clear();

double k1 = InputNumber("Введите значение K1: ");
double b1 = InputNumber("Введите значение B1: ");
double k2 = InputNumber("Введите значение K2: ");
double b2 = InputNumber("Введите значение B2: ");
PointXY(out double x, out double y);

Console.WriteLine($"Координаты пересечения прямых X: {x} Y: {y}");

// Считаем X
void PointXY(out double x, out double y)
{
    x = Math.Round((-b2 + b1) / (-k1 + k2), 2);
    y = Math.Round(k2 * x + b2, 2);
    //return x;
}

// Считаем Y
// double PointY()
// {
//     double y = Math.Round(k2 * PointX() + b2, 2);
//     return y;
// }

// Проверяем чтобы вводились только числа
double InputNumber(string str)
{
    double number;
    string text;

    while (true)
    {
        Console.Write(str);
        text = Console.ReadLine();
        if (double.TryParse(text, out number))
        {
            break;
        }
        Console.WriteLine("Введено не число, попробуйте еще раз.");
    }
    return number;
}
