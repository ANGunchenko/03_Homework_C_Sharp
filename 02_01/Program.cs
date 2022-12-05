// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1



Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int array = number.ToString().Length;

int result = ((number / 10) % 10);

if (array < 3 || array > 3)
{
    Console.WriteLine("Введено не трехзначное число");
}
else
{
    Console.WriteLine(result);
}
