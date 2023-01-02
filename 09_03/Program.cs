// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



Console.Clear ();

int m = inputNumber("Введите число M: ");
int n = inputNumber("Введите число N: ");
Console.WriteLine($"Функция Аккермана ({m}, {n}) = {functionAkkerman(m, n)}");

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

int functionAkkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return functionAkkerman(m - 1, 1);
    else
        return functionAkkerman(m - 1, functionAkkerman(m, n - 1));
}
